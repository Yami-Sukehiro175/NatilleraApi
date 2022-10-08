using NatilleraApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NatilleraApi.Clases
{
    public class clsCiudad
    {
        public Ciudad ciudad;
        private NatilleraEntities Natillera = new NatilleraEntities();
        public List<viewCombos> LlenarComboCiudad()
        {
            return Natillera.Ciudad.Select(p => new viewCombos { Valor=p.IDCiudad.ToString(),Texto=p.NombreCiudad.ToString()}).ToList();
        }
    }
}