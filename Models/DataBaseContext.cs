using Microsoft.EntityFrameworkCore;
using System;

namespace BlogApp.Models
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) 
        {

        }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Blog>(Blog =>
            {
                Blog.Property(e=>e.CreateTime).HasDefaultValue(DateTime.Now);

                Blog.Property(e=>e.Title).HasMaxLength(500);

                Blog.Property(e=>e.Title).HasColumnName("blogTitle");
            });
        }
    }
}
