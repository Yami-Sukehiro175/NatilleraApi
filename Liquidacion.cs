//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NatilleraApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Liquidacion
    {
        public int IDLiquidacion { get; set; }
        public string IdCliente { get; set; }
        public double ValorAhorrado { get; set; }
        public double ValorPrestado { get; set; }
        public double Ganancias { get; set; }
        public System.DateTime FechaLiquidacion { get; set; }
        public double Total { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
