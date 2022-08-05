using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public string CustomerId { get; set; }
        public string ProductName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int LicenseTerm { get; set; } //değişkeni değiştir Lisans Süresini ayarla.
        public DateTime LisenceEndDate { get; set; }
        public decimal PurchasePrice { get; set; } //değişkeni değiştir 
        public string CustomerNote { get; set; }
        public string ProductVersion { get; set; } 
        public string CustomerCompanyName { get; set; }
        public string CustomerCompanyAdress { get; set; }
        public string CompanyBusinessArea { get; set; }
        public string CompanyWebAdress { get; set; }
        public string ExecutiveName { get; set; }
        public int ExecutivePhoneNumber { get; set; } 

        public string ExecutiveEmail { get; set; }





    }
}
