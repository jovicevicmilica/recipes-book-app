using Projekat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Repositories
{
    internal class TypeMealRepository
    {
        public static List<TypeMeal> GetTypeMealList()
        {
            List<TypeMeal> result = new List<TypeMeal>();
            result.Add(new TypeMeal { Naziv = "predjelo" });
            result.Add(new TypeMeal { Naziv = "jelo" });
            result.Add(new TypeMeal { Naziv = "dezert" });

            return result;
        }
    }
}
