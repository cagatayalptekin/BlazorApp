using Microsoft.EntityFrameworkCore;
using BlazorApp2.Data.Models;
using System;

namespace BlazorApp2.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
