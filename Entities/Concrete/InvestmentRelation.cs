using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class InvestmentRelations : IEntity
    {
        public int InvestmentRelationsId { get; set; }
        public string InvestorName { get; set; }
        public string InvestorSurname { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }
        public string Adress { get; set; }
        public string Company { get; set; }

        public string Position { get; set; }

        public string Note { get; set; }
        public DateTime DateOfUpload { get; set; }
    }
}
