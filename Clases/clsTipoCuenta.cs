using NatilleraApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NatilleraApi.Clases
{
    public class clsTipoCuenta
    {
        public TipoCuenta tipocuenta;
        private NatilleraEntities Natillera = new NatilleraEntities();
        public List<viewCombos> LlenarComboTipoCuenta()
        {
            return Natillera.TipoCuenta.Select(p => new viewCombos { Valor = p.IdTipoCuenta.ToString(), Texto = p.NombreTipoCuenta.ToString() }).ToList();
        }
    }
}