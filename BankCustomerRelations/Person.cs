﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankCustomerRelations
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public enum Gender
        {
            Female,
            Male
        }


    }
}
