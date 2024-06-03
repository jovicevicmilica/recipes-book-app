using Projekat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Repositories
{
    internal class MeasurementRepository
    {
        public static List<Measurement> GetMeasurementList()
        {
            List<Measurement> result = new List<Measurement>();
            result.Add(new Measurement { Naziv = "g" });
            result.Add(new Measurement { Naziv = "kg" });
            result.Add(new Measurement { Naziv = "kom" });
            result.Add(new Measurement { Naziv = "kašičica" });
            result.Add(new Measurement { Naziv = "kašika" });
            result.Add(new Measurement { Naziv = "ml" });
            result.Add(new Measurement { Naziv = "l" });
            result.Add(new Measurement { Naziv = "šolja" });
            result.Add(new Measurement { Naziv = "prstohvat" });
            result.Add(new Measurement { Naziv = "šaka" });
            result.Add(new Measurement { Naziv = "dl" });
            result.Add(new Measurement { Naziv = "mg" });
            result.Add(new Measurement { Naziv = "dg" });

            return result;
        }
    }
}
