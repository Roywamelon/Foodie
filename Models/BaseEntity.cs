using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodie.Models
{
    public abstract class BaseEntity
    {
        public int Id{get; set;}

        public BaseEntity(int id)
        {
            Id = id;
        }

        public void Greet()
        {
            System.Console.WriteLine("hello...");
        }
    }
}