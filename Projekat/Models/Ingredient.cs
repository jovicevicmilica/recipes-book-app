using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class Ingredient
    {
        public int SastojakID { get; set; }  //primarni ključ, ne može biti null
        public string Naziv { get; set; }  //naziv sastojka
    }
}
