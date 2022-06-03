using System;
using Microsoft.EntityFrameworkCore;
using e_shopping.Models;
using Type = e_shopping.Models.Type;
using System.Collections.Generic;

namespace e_shopping.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):
        base(options)
        {
            
        }
        public DbSet<Categories> categories { get; set; }

        public DbSet<Type> types {get;set;}
        public DbSet<login> logins {get; set;}
        public DbSet<register> registers {get; set;}
    }
}