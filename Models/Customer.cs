using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop.Models
{
    public enum Sexes
    {
        Male,
        Female,
        Other
    }
    public enum MemberShipTypes
    {
        Yearly,
        Monthly,
        Biweekly
    }
    public enum PaymentTypes
    {
        Debit,
        Credit
    }
    public class Customer : User
    {
        public DateTime? LastVisit { get; set; }
        public string PaymentType { get; set; }
        public string MembershipType { get; set; }
        public string Sex { get; set; }

        public Customer(DateTime? lastVisit, string sex, string membershipType, string firstName, string paymentType, string lastName) : base(firstName, lastName)
        {
            LastVisit = lastVisit;
            PaymentType = paymentType == "debit" ? PaymentTypes.Debit.ToString() : PaymentTypes.Credit.ToString();

            if (sex == "male")
            {
                Sex = Sexes.Male.ToString();
            }
            else if (sex == "female")
            {
                Sex = Sexes.Female.ToString();

            }
            else if (sex == "other")
            {
                Sex = Sexes.Other.ToString();
            }
            else
            {
                throw new Exception("Invalid sex");
            }


            if (membershipType == "Yearly")
            {
                MembershipType = MemberShipTypes.Yearly.ToString();
            }
            else if (membershipType == "Monthly")

            {
                MembershipType = MemberShipTypes.Monthly.ToString();
            }
            else if (membershipType == "BiWeekly")
            {
                MembershipType = MemberShipTypes.Biweekly.ToString();
            }
            else
            {
                throw new Exception("Invalid membership type");
            }


        }
    }
}
