using System;
using System.Globalization;

namespace ClassesandObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer ("Bakare Barakat", 987657654, 08026545677, 13, false, 12345678, "Savings");
            Console.WriteLine("");
            Customer ("Olajumoke Ikeoluwa", 987654086, 08024345875, 21, true, 12332178, "Current");
            Console.WriteLine("");
            Customer ("Banjo Museedat", 987657801, 08024345089, 43, false, 12398778, "Savings");
            Console.WriteLine("");
            Customer ("Adeleke Richard", 543654321, 08090876677, 11, true, 123765678, "Current");
            Console.WriteLine("");
            Customer ("Bakare Mujeeb", 876583261, 08024376677, 17, false, 167345690, "Current");
        }
        public static void Customer (string accountname, long bvn, long phonenumber, int age, bool accdelete, long accnumber, string acctype)
        {
            Bank Halimat = new Bank();
                {
                    Halimat.AccountName = accountname;
                    Halimat.BVN  = bvn;
                    Halimat.PhoneNumber = phonenumber;
                    Halimat.Age = age; 
                
                    AccountDetails Accdetails = new AccountDetails();
                    {
                        Random rnd = new Random();
                        Accdetails.Accountdeleted = accdelete;
                        Accdetails.AccountNumber = accnumber;
                        Accdetails.AccountType = acctype;
                        Accdetails.AmountInAccount = rnd.Next(2000, 1000000);
                    }
                    Halimat.AccDetails.Add(Accdetails);
                    Console.WriteLine($"Account Name: {Halimat.AccountName}");
                    Console.WriteLine($"BVN Number: {Halimat.BVN}");
                    Console.WriteLine($"Phone Number: {Halimat.PhoneNumber}");
                    Console.WriteLine($"Age: {Halimat.Age}");
                    Console.WriteLine("Amount In Account: "+  Halimat.AccDetails[0].AmountInAccount.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));
                    Console.WriteLine($"Account Number: {Halimat.AccDetails[0].AccountNumber}");
                    Console.WriteLine($"Account Type: {Halimat.AccDetails[0].AccountType}");
                    Console.WriteLine($"Is Account deleted: {Halimat.AccDetails[0].Accountdeleted}");
                }
        }        
    }
}
