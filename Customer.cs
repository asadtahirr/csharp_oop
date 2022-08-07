using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop 
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
        public string MemberShipType { get; set; }
        public string Sex { get; set; }
        
        public Customer(DateTime? lastVisitInGym,string customerSex,string typeOfMembership, string userFirstName,bool isCustomerDebitPayment,string userLastName) : base(userFirstName, userLastName)
        {
            LastVisit = lastVisitInGym;
            PaymentType = isCustomerDebitPayment ? PaymentTypes.Debit.ToString() : PaymentTypes.Credit.ToString();
            
            if(customerSex == "Male")
            {
                Sex = Sexes.Male.ToString();
            }
            else if(customerSex == "Female")
            {
                Sex = Sexes.Female.ToString();

            }
            else if(customerSex == "Other")
            {
                Sex = Sexes.Other.ToString(); 
            }
            else
            {
                throw new Exception("Invalid sex");
            }
          
            
            if(typeOfMembership == "Yearly")
            {
                MemberShipType = MemberShipTypes.Yearly.ToString();
            }else if(typeOfMembership == "Monthly")

            {
                MemberShipType = MemberShipTypes.Monthly.ToString();
            }
            else if (typeOfMembership == "BiWeekly")
            {
                MemberShipType = MemberShipTypes.Biweekly.ToString();
            }
            else
            {
                throw new Exception("Invalid membership type");
            }
            
            
        }
    }
}
