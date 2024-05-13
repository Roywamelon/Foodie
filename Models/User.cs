using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodie.Models
{
    public class User : BaseEntity
    {
        public string Email{get; set;} = default!;
        public int Pin{get; set;}
        public string RoleName{get; set;} = default!;
        public string FirstName{get; set;} = default!;
        public string LastName{get; set;} = default!;
        public string? Gender{get; set;}
        public string? Address{get; set;}
        public string Phone{get; set;} = default!;

        public User(int id, string email, int pin,string roleName,string firstName, string lastName, string gender, string address, string phone) : base(id)
        {
            Email = email;
            Pin = pin;
            RoleName = roleName;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Address = address;
            Phone = phone;
        }
    }
}