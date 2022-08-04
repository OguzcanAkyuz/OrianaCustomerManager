using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.Concrete.Meetings;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace DataAccess.Concrete.EntityFramework
{
    public class CustomerManagerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CustomerManager;Trusted_Connection=true");
        }


        public DbSet<RoutineService> RoutineServices { get; set; }

        public DbSet<InvestmentRelation> InvestmentRelations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CuriousCustomer> CuriousCustomers { get; set; }
        public DbSet<AbroadInvestmentRelations> AbroadInvestmentRelations { get; set; }

        public DbSet<FinishedMeetings> FinishedMeetings { get; set; }
        public DbSet<ScheduledMeetings> ScheduledMeetings { get; set; }




    }
}
