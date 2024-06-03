using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Models
{
    internal class Menu
    {
        public int MeniID { get; set; }  //primarni ključ, ne može biti null
        public string Naziv { get; set; }  //naziv menija
        public string Opis { get; set; }   //opis menija
        public DateTime DatumKreiranja { get; set; }  //datum kreiranja menija
    }
}
