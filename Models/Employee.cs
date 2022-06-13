using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCRUDDemo.Models
{
    public class Employee
    {
        public Employee(int iD, string firstName, string secondName, string address, string phone)
        {
            this.ID = iD;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Address = address;
            this.Phone = phone;

        }
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}