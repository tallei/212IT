using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactWeb.Data
{
    public class DbInitializer
    {
        public static void Initialize(HarrisDbContext context) // initialize the database 
        {
            context.Database.EnsureCreated(); // make sure the database is built when system is launched  

        }
    }
}
