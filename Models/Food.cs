using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodie.Models
{
    public class Food : BaseEntity
    {
        public string Name{get; set;} = default!;
        public string? CategoryName{get; set;}
        public int Quantity{get; set;}
        public double Price{get; set;}

        public Food(int id, string name, string categoryName, int qty, double price) : base(id)
        {
            Name = name;
            CategoryName = categoryName;
            Quantity = qty;
            Price = price;
        }

    }
}