using NatilleraApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NatilleraApi.Clases
{
    public class clsCampos
    {
        public Cliente cliente { get; set; }
        private NatilleraEntities Natillera = new NatilleraEntities();
        public List<ClienteListaAhorro> ListarClientes()
        {
            //return Natillera.Cliente.ToList();
            var query = from Clie in Natillera.Set<Cliente>()
                        join Ciu in Natillera.Set<Ciudad>()
                        on Clie.IdCiudad equals Ciu.IDCiudad
                        join Tic in Natillera.Set<TipoCuenta>()
                        on Clie.IdTipoCuenta equals Tic.IdTipoCuenta
                        join Banc in Natillera.Set<Banco>()
                        on Clie.IdBanco equals Banc.IDbanco
                        join Aho in Natillera.Set<Ahorro>()
                        on Clie.Documento equals Aho.IDCliente
                        select new ClienteListaAhorro
                        {
                            IDAhorro=Aho.IDAhorro,
                            Documento = Clie.Documento.ToString(),
                            Nombre = Clie.Nombre.ToString(),
                            TipoCuentaModelo = Tic.NombreTipoCuenta.ToString(),
                            NumeroCuenta = Clie.NumeroCuenta.ToString(),
                            BancoModelo = Banc.NombreBanco.ToString(),
                            FechaAhorro=Aho.FechaAhorro,
                            ValorAhorrado = Aho.ValorAhorrado,
                        };
            return query.ToList();

        }
        public List<ClienteListaPrestamo> ListarClientesPrestamo() {
            var query = from Clie in Natillera.Set<Cliente>()
                        join Ciu in Natillera.Set<Ciudad>()
                        on Clie.IdCiudad equals Ciu.IDCiudad
                        join Tic in Natillera.Set<TipoCuenta>()
                        on Clie.IdTipoCuenta equals Tic.IdTipoCuenta
                        join Banc in Natillera.Set<Banco>()
                        on Clie.IdBanco equals Banc.IDbanco
                        join Pres in Natillera.Set<Prestamo>()
                        on Clie.Documento equals Pres.IDCliente
                        select new ClienteListaPrestamo
                        {
                            IDPrestamo = Pres.IDPrestamo,
                            Documento = Clie.Documento.ToString(),
                            Nombre = Clie.Nombre.ToString(),
                            TipoCuentaModelo = Tic.NombreTipoCuenta.ToString(),
                            NumeroCuenta = Clie.NumeroCuenta.ToString(),
                            BancoModelo = Banc.NombreBanco.ToString(),
                            FechaPrestamo = Pres.FechaPrestamo,
                            ValorPrestado = Pres.ValorPrestado,
                            InteresPorcentaje=Pres.InteresPor,
                            TotalPrestamo=Pres.ValorTotalPrestamo
                        };
            return query.ToList();
        }


    }
}