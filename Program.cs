using System;
using System.Globalization;

namespace ClassesandObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer ();
            Console.WriteLine("");
            Customer ();
            Console.WriteLine("");
            Customer ();
            Console.WriteLine("");
            Customer ();
            Console.WriteLine("");
            Customer ();
        }
            public static void Customer ()
        {
            try
            {
                Bank Halimat = new Bank();
                    {
                        Console.Write("Enter your full name: ");
                        Halimat.AccountName = Console.ReadLine();
                        Console.Write("Enter your BVN number: ");
                        Halimat.BVN = long.Parse(Console.ReadLine());
                        Console.Write("Enter your phone number: ");
                        Halimat.PhoneNumber = long.Parse(Console.ReadLine());
                        Console.Write("Enter your age: ");
                        Halimat.Age = int.Parse(Console.ReadLine()); 
                    
                        AccountDetails Accdetails = new AccountDetails();
                        {
                            Random rnd = new Random();
                            Accdetails.AccountNumber = rnd.Next(12345678, 98765432);
                            Console.WriteLine("There are two type of account. A savings and Current");
                            Console.Write("What type of account would you like to open: ");
                            Accdetails.AccountType = Console.ReadLine();
                            Console.Write("Enter amount,minimum: $2,000 and Maximum: $1,000,000: ");
                            Accdetails.AmountInAccount = long.Parse(Console.ReadLine());
                            Console.Write("Do you want to delete this account: ");
                            Accdetails.Accountdeleted = Console.ReadLine();
                            
                        }
                        Halimat.AccDetails.Add(Accdetails);
                        if(Accdetails.AccountType != "Current" || Accdetails.AccountType != "Savings" )
                        {
                            Accdetails.AccountType = "Account type can only be Current or Savings";

                        }
                        else if (Accdetails.AccountType == "Current" || Accdetails.AccountType == "Savings")
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Wrong input");
                        }
                        if (Accdetails.AmountInAccount <= 2000 ||Accdetails.AmountInAccount >= 1000000 )
                        {
                            Accdetails.AmountInAccount = 0;
                            Console.WriteLine("");
                            Console.WriteLine("Amount is either below $2,000 or higher than $1,000,000, So you wont be able to input the money ");
                        }
                        else
                        {
                            Console.WriteLine("");
                        }

                        if (Accdetails.Accountdeleted == "yes")
                        {
                            Console.WriteLine("Account Deleted");
                        }
                        else if(Accdetails.Accountdeleted == "no")
                        {
                            
                        Console.WriteLine($"Account Name: {Halimat.AccountName}");
                        Console.WriteLine($"BVN Number: {Halimat.BVN}");
                        Console.WriteLine($"Phone Number: {Halimat.PhoneNumber}");
                        Console.WriteLine($"Age: {Halimat.Age}");
                        Console.WriteLine("Amount In Account: "+  Halimat.AccDetails[0].AmountInAccount.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));
                        Console.WriteLine($"Account Number: {Halimat.AccDetails[0].AccountNumber}");
                        Console.WriteLine($"Account Type: {Halimat.AccDetails[0].AccountType}");
                        }
                        else 
                        {
                            Console.WriteLine("Wrong input");
                        }
                    }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
               
    }
}
