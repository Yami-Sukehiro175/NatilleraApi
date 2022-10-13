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
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Ahorro = new HashSet<Ahorro>();
            this.Liquidacion = new HashSet<Liquidacion>();
            this.Prestamo = new HashSet<Prestamo>();
        }
    
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public string Direccion { get; set; }
        public int IdCiudad { get; set; }
        public int IdTipoCuenta { get; set; }
        public string NumeroCuenta { get; set; }
        public int IdBanco { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Ocupacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<Ahorro> Ahorro { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Banco Banco { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Ciudad Ciudad { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual TipoCuenta TipoCuenta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<Liquidacion> Liquidacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<Prestamo> Prestamo { get; set; }
    }
}
