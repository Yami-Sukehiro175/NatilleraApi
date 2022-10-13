using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NatilleraApi.Models
{
    public class ClienteListaPrestamo
    {
        public int IDPrestamo { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }

        public string BancoModelo { get; set; }
        public string TipoCuentaModelo { get; set; }
        public string NumeroCuenta { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public Double ValorPrestado { get; set; }
        public Double InteresPorcentaje { get; set; }
        public Double TotalPrestamo { get; set; }
    }
}