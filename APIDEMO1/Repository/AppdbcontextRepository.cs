using System.Collections.Generic;
using APIDEMO1.Models;
using Microsoft.EntityFrameworkCore;


namespace APIDEMO1.Repository
{
  
    
        public class AppdbcontextRepository : DbContext
        {

            public AppdbcontextRepository(DbContextOptions<AppdbcontextRepository> options)
                     : base(options)
            {
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=DemoData;Integrated Security=True");
                }
            }
            public DbSet<Employee> Employees { get; set; }
        }

    

}
