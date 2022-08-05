using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CuriousCustomer : IEntity
    {
        public string CuriousCustomerId { get; set; }
        public string CuriousCustomerName { get; set; }
        public string CuriousCustomerSurname { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }
        public string Adress { get; set; }
        public string Company { get; set; }

        public string Position { get; set; }

        public string Note { get; set; }
        public DateTime DateOfUpload { get; set; }
        public string ProductId { get; set; } //Database Ekle





    }
}
