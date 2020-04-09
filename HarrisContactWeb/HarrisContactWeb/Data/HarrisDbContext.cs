using HarrisContactWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactWeb.Data
{
    public class HarrisDbContext : DbContext // inherit dbcontext, it uses microsoft entity framework core  
    {
        public HarrisDbContext(DbContextOptions<HarrisDbContext> options) : base (options)
        {
        }
        public DbSet<PersonalContact> PersonalContacts { get; set; } // telling database set to create personal contact 
        public DbSet<BusinessContact> BusinessContacts { get; set; } // telling database set to create personal contact 


    }
}
