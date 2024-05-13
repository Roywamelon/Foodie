using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodie.Models
{
    public class Category : BaseEntity
    {
        public string Name{get; set;} = default!;
        public string? Description{get; set;}

        public Category(int id, string name, string description) : base(id)
        {
            Name = name;
            Description = description;
        }

        public void Greet(int a)
        {
            System.Console.WriteLine("good morning");
        }
    }
}