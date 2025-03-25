﻿using Microsoft.EntityFrameworkCore;

namespace CIS_174_Project.Models.ToDoList
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

        public DbSet<ToDo> ToDos { get; set; } = null!;
        public DbSet<Status> Statuses { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "todo", Name = "ToDo" },
                new Status { StatusId = "inprogress", Name = "InProgress" },
                new Status { StatusId = "qa", Name = "QA" },
                new Status { StatusId = "done", Name = "Done" }
            );
        }
    }
}
