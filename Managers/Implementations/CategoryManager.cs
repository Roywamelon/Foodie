using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foodie.Context;
using Foodie.Managers.Interfaces;
using Foodie.Models;

namespace Foodie.Managers.Implementations
{
    public class CategoryManager : ICategoryManager
    {
        public Category Create(string name, string description)
        {
            var exist = IsExist(name);
            if(exist)
            {
                System.Console.WriteLine($"category {name} already exist");
                return null;
            }
            var id = FoodContext.CategoryTable.Count + 1;
            Category category = new Category(id,name, description);
            FoodContext.CategoryTable.Add(category);
            return category;
        }

        public bool Delete(string name)
        {
            var category = Get(name);
            if(category == null)
            {
                System.Console.WriteLine($"{name} doesnt exist");
                return false;
            }
            FoodContext.CategoryTable.Remove(category);

            for(int i = category.Id + 1; i<=FoodContext.CategoryTable.Count; i++)
            {
                var obj = Get(i);
                obj.Id--;
            }
            System.Console.WriteLine($"{name} deleted successfully");
            return true;
        }

        public Category Get(int id)
        {
            foreach (var item in FoodContext.CategoryTable)
            {
                if(item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public Category Get(string name)
        {
            foreach (var item in FoodContext.CategoryTable)
            {
                if(item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Category> GetAll()
        {
            return FoodContext.CategoryTable;
        }

        public Category Update(string name, string description)
        {
            throw new NotImplementedException();
        }

        private bool IsExist(string name)
        {
            foreach (var item in FoodContext.CategoryTable)
            {
                if(item.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}