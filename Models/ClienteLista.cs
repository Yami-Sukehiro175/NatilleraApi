using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NatilleraApi.Models
{
    public class ClienteLista
    {
        public string Documento { get; set; }
         public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Direccion { get; set; }
        public string CiudadNombre { get; set; }
        public string TipoCuentaModelo { get; set; }
        public string NumeroCuenta { get; set; }
        public string BancoModelo { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Ocupacion { get; set; }
    }
}