namespace TestProjPoint.Data.DbContext
{
    using Microsoft.EntityFrameworkCore;
    using TestProjPoint.Models;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<PointFigure> PointFigure { get; set; }
    }
}
