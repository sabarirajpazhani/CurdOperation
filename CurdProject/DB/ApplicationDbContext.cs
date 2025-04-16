﻿using CurdProject.Model;
using Microsoft.EntityFrameworkCore;

namespace CurdProject.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) 
        {
            
        }

        public DbSet<Student> students { get; set; }    
    }
}
