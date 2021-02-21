using System;
using System.Collections.Generic;
using System.Text;

namespace BankCustomerRelations
{
    class Customer : Person
    {

        public string BankIBAN { get; set; }
        public string AccountType { get; set; }
        public string CustomerType { get; set; }
        public List<string> CreditCards { get; set; }
        public double AccountBalance { get; private set; }
        public bool IsAccountStockMarketRegistered { get; set; }

    }
}
