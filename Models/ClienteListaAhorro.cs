using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NatilleraApi.Models
{
    public class ClienteListaAhorro
    {
        public int IDAhorro { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        
        public string BancoModelo { get; set; }
        public string TipoCuentaModelo { get; set; }
        public string NumeroCuenta { get; set; }
        public DateTime FechaAhorro { get; set; }
        public Double ValorAhorrado { get; set; }
    }
}