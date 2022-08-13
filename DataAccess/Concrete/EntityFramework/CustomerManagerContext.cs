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


        public DbSet<RoutineService> RoutineService { get; set; }

        public DbSet<InvestmentRelation> InvestmentRelation { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CuriousCustomer> CuriousCustomer { get; set; }
        public DbSet<AbroadInvestmentRelation> AbroadInvestmentRelation { get; set; }

        public DbSet<FinishedMeeting> FinishedMeeting { get; set; }
        public DbSet<ScheduledMeeting> ScheduledMeeting { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Participant> Participant { get; set; }



        //DEĞİŞTİRDİĞİN İSİMLERİ DATABASE DE TANIMLA VEYA DEĞİŞTİR.



    }
}
