using System;
using System.Collections.Generic;
using System.Text;

namespace BankCustomerRelations
{
    class Customer : Person
    {
        public string BankAccount { get; set; }
        public string AccountType { get; set; }
        public List<string> CreditCards { get; set; }

    }
}
