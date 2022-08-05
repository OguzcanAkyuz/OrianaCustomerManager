using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class PotentialCustomer : IEntity
    {
        public string PotentialCustomerId { get; set; }
        public string PotentialCustomerName { get; set; }
        public string PotentialCustomerSurname { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
        public string Adress { get; set; }
        public string Company { get; set; }

        public string Position { get; set; }

        public string Note { get; set; }
        public DateTime DateOfUpload { get; set; }



    }
}
