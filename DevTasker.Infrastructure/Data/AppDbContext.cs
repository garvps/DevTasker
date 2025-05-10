using DevTasker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevTasker.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<TaskItem> Tasks => Set<TaskItem>();
}
