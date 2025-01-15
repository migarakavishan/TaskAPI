using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using TaskAPI.Models;

namespace TaskAPI.DataAccess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace with your SQL Server details, including username and password
            var connectionString = "Server=DESKTOP-UDGL6OG; Database=MyTodoDb; Trusted_Connection=True; TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString)
                .ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new Author { Id = 1, FullName = "Migara Kavishan"},
                new Author { Id = 2, FullName = "Sajith"},
                new Author { Id = 3, FullName = "Nimal"},
                new Author { Id = 4, FullName = "kamal"},

            });


            modelBuilder.Entity<Todo>().HasData(new Todo[]
            {
                new Todo
                {
                    Id = 1,
                    Title = "Get books for school - DB",
                    Description = "Get some text books for school",
                    CreatedDate = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 1,
                },

                new Todo
                {
                    Id = 2,
                    Title = "Need some  - DB",
                    Description = "Go supermarket",
                    CreatedDate = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 1,
                },

                new Todo
                {
                    Id = 3,
                    Title = "Purchace Camera  - DB",
                    Description = "Buy new camera",
                    CreatedDate = DateTime.Now,
                    Due = DateTime.Now.AddDays(5),
                    Status = TodoStatus.New,
                    AuthorId = 2,
                },
            });
        }
    } 
}
