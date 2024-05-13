using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodie.Models
{
    public class Manager : BaseEntity
    {
        public string UserEmail{get; set;} = default!;
        public string StaffNumber{get; set;} = default!;
        public string Qualification{get; set;} = default!;
        public int YearsOfExperience{get; set;} = default!;

        public Manager(int id, string userEmail, string staffNumber, string qualification, int yoe) : base(id)
        {
            UserEmail = userEmail;
            StaffNumber = staffNumber;
            Qualification = qualification;
            YearsOfExperience = yoe;
        }

    }
}