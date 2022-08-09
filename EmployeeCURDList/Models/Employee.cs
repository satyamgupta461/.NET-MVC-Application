using System;
namespace EmployeeCURDList.Models
{
    public class Employee
    {
        public Employee()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public string City { get; set; }

    }

}
