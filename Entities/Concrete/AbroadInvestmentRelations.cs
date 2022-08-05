using Core.Entities;

namespace Entities.Concrete
{
    public class AbroadInvestmentRelation : IEntity
    {
        public string AbroadInvestorId { get; set; }

        public string AbroadInvestorName { get; set; }
        public string AbroadInvestorSurname { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }
        public string Adress { get; set; }
        public string Company { get; set; }

        public string Position { get; set; }

        public string Note { get; set; }
        public float DateOfUpload { get; set; }

        public string Country { get; set; }



    }
}
