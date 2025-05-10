using DevTasker.Domain.Interfaces;
using DevTasker.Infrastructure.Data;
using DevTasker.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using DevTasker.Domain.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=tasks.db"));

builder.Services.AddScoped<ITaskRepository, TaskRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

// Endpoints
app.MapGet("/tasks", async (ITaskRepository repo) =>
    Results.Ok(await repo.GetAllAsync()));

app.MapGet("/tasks/{id}", async (int id, ITaskRepository repo) =>
    await repo.GetByIdAsync(id) is TaskItem task
        ? Results.Ok(task)
        : Results.NotFound());

app.MapPost("/tasks", async (TaskItem task, ITaskRepository repo) =>
{
    var created = await repo.AddAsync(task);
    return Results.Created($"/tasks/{created.Id}", created);
});

app.MapPut("/tasks/{id}", async (int id, TaskItem updatedTask, ITaskRepository repo) =>
{
    var existing = await repo.GetByIdAsync(id);
    if (existing is null) return Results.NotFound();

    existing.Title = updatedTask.Title;
    existing.Description = updatedTask.Description;
    existing.DueDate = updatedTask.DueDate;
    existing.IsCompleted = updatedTask.IsCompleted;

    await repo.UpdateAsync(existing);
    return Results.NoContent();
});

app.MapDelete("/tasks/{id}", async (int id, ITaskRepository repo) =>
{
    await repo.DeleteAsync(id);
    return Results.Ok();
});

app.Run();
