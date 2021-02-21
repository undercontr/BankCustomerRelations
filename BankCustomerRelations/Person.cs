using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BankCustomerRelations
{
    class Person
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string TcNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public enum Gender
        {
            Female,
            Male
        }

    }
}
