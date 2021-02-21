using System;
using System.Collections.Generic;
using System.Text;

namespace BankCustomerRelations
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine($@"Customer Added: {customer.Name} {customer.LastName} ");
        }

        public void UpdateCustomer(Customer customer)
        {
            Console.WriteLine($@"Customer Updated: {customer.Name} {customer.LastName} ");
        }

        public void RemoveCustomer(Customer customer)
        {
            Console.WriteLine($@"Customer Removed: {customer.Name} {customer.LastName} ");
        }

        public Customer BringCustomer(Customer customer)
        {
            //Get customer Id and match in SQL and return the customer

            return customer;
        }
    }
}
