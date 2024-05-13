using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foodie.Models;

namespace Foodie.Managers.Interfaces
{
    public interface ICategoryManager
    {
        Category Create(string name, string description);
        Category Get(int id);
        Category Get(string name);
        List<Category> GetAll();
        Category Update(string name,string description);
        bool Delete(string name);
    }
}