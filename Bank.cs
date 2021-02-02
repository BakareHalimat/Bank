using System.Collections.Generic;

namespace ClassesandObject
{
    public class Bank
    {
        public string AccountName{get; set;}
        public long BVN {get; set;}
        public long PhoneNumber {get; set;}
        public int Age {get; set;}
        
        public List<AccountDetails> AccDetails {get; set;} = new List<AccountDetails>();

    }
}