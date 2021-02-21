using System;
using System.Collections.Generic;

namespace BankCustomerRelations
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                 Id = 1,
                 Name = "Engin",
                 LastName = "Demiroğ",
                 TcNo = "12345678900",
                 PhoneNumber = "00905659883265",
                 DateOfBirth = new DateTime(1991, 09, 07),
                 Address = "Diyarbakır",
                 Email = "engin@demirog.com",
                 AccountType = "Checking Account",
                 BankIBAN = "TR00 0000 0000 0000 0000 0000 00".Replace(" ", ""),
                 CustomerType = "Yağlı Customer",
                 CreditCards = new List<string> {"1234 5678 9000 0000", "7894 5612 0000 0000"},
                 IsAccountStockMarketRegistered = true,
                 Gender = Person.GenderEnum.Male
            };

            CustomerManager customerManager = new CustomerManager();

            Console.WriteLine(customerManager.BringCustomer(customer).Name);
        }
    }
}
