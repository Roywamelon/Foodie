using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foodie.Models;

namespace Foodie.Context
{
    public class FoodContext
    {
        public static List<Category> CategoryTable = new List<Category>();
        public static List<Customer> CustomerTable = new List<Customer>();
        public static List<DeliveryMan> DeliveryManTable = new List<DeliveryMan>();
        public static List<Food> FoodTable = new List<Food>();
        public static List<Manager> ManagerTable = new List<Manager>();
        public static List<Order> OrderTable = new List<Order>();
        public static List<Role> RoleTable = new List<Role>();
        public static List<User> UserTable = new List<User>();
    }
}