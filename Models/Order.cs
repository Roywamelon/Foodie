using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodie.Models
{
    public class Order : BaseEntity
    {
        public string RefNumber{get; set;} = default!;
        public string CustomerTagNumber{get; set;} = default!;
        public bool IsDelivered{get; set;}
        public Dictionary<string, int> OrderedFoods{get; set;} = new Dictionary<string, int>();
        public DateTime DateOrdered{get; set;}
        public double TotalPrice{get; set;}

        public Order(int id, string refNumber, string tagNumber, bool isDelivered, Dictionary<string, int> foods, DateTime date, double totalPrice) : base(id)
        {
            RefNumber = refNumber;
            CustomerTagNumber = tagNumber;
            IsDelivered = isDelivered;
            OrderedFoods = foods;
            DateOrdered = date;
            TotalPrice = totalPrice;
        }

    }
}