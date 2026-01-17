using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagementSystem
{
    public class Account
    {
        private string accountNumber;
        private string name;
        private float balance;
        private string tin;
        private string nid;
        private DateTime dob;
        private string address;
        private string nominee;
        private string accountStatus;
        private byte accountType;

        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public float Balance { get; set; }
        public string Tin { get; set; }
        public string Nid { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string Nominee { get; set; }
        public string AccountStatus { get; set; }
        public byte AccountType { get; set; }

        public Account() {}

        public Account(string acNo, string name, DateTime dob, float balance, string tin, string nid, string address, string nominee, string accountStatus, byte accountType)
        {
            AccountNumber = acNo;
            Name = name;
            Dob = dob;
            Balance = balance;
            Tin = tin;
            Nid = nid;
            Address = address;
            Nominee = nominee;
            AccountStatus = accountStatus;
            AccountType = accountType;
        }

    }
}
