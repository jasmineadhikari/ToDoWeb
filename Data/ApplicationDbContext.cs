using Microsoft.EntityFrameworkCore;
using ToDoWeb.Models;

namespace ToDoWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<UserToDo> UserTodos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<UserToDo>()
                .HasKey(ut => new { ut.UserId, ut.TodoItemId });

            
            modelBuilder.Entity<UserToDo>()
                .HasOne(ut => ut.User)
                .WithMany(u => u.UserTodos)
                .HasForeignKey(ut => ut.UserId);

            
            modelBuilder.Entity<UserToDo>()
                .HasOne(ut => ut.TodoItem)
                .WithMany(t => t.UserTodos)
                .HasForeignKey(ut => ut.TodoItemId);
        }
    }
}