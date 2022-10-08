using NatilleraApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NatilleraApi.Clases
{
    public class clsBanco
    {
        public Banco banco;
        private NatilleraEntities Natillera = new NatilleraEntities();
        public List<viewCombos> LlenarComboBanco()
        {
            return Natillera.Banco.Select(p => new viewCombos { Valor = p.IDbanco.ToString(), Texto = p.NombreBanco.ToString() }).ToList();
        }
    }
}