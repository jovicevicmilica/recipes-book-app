using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class Recipe
    {
        public int RecipeID { get; set; }  //primarni ključ, ne može biti null
        public string Naziv { get; set; }  //naziv recepta
        public string Opis { get; set; }   //opis recepta
        public int VrijemePripreme { get; set; }  //vrijeme pripreme, u minutima
        public int VrijemeKuvanja { get; set; }   //vrijeme kuvanja, u minutima
        public int UkupnoVrijeme { get; set; }    //ukupno vrijeme, u minutima
        public int BrojPorcija { get; set; }      //broj porcija
    }
}
