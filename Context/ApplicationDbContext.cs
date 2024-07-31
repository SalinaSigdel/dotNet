using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstProject.Model;
using Microsoft.EntityFrameworkCore;
using Model;


namespace firstProject.Context
{
    public class ApplicationDbContext : DbContext
    {
         public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<hotel> Hotels {get; set;} 
        public DbSet<user> Users {get; set;}    
    }
}