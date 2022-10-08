﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NatilleraApi.Models;

namespace NatilleraApi.Clases
{
    public class clsCliente
    {
        public Cliente cliente { get; set; }
        private NatilleraEntities Natillera = new NatilleraEntities();
        public List<ClienteLista> ListarClientes()
        {
            //return Natillera.Cliente.ToList();
            var query = from Clie in Natillera.Set<Cliente>()
                        join Ciu in Natillera.Set<Ciudad>()
                        on Clie.IdCiudad equals Ciu.IDCiudad
                        join Tic in Natillera.Set<TipoCuenta>()
                        on Clie.IdTipoCuenta equals Tic.IdTipoCuenta
                        join Banc in Natillera.Set<Banco>()
                        on Clie.IdBanco equals Banc.IDbanco
                        select new ClienteLista { Documento = Clie.Documento.ToString(), Nombre = Clie.Nombre.ToString(), FechaNacimiento = Clie.FechaNacimiento, FechaIngreso = Clie.FechaIngreso, Direccion = Clie.Direccion.ToString(), CiudadNombre=Ciu.NombreCiudad.ToString(), TipoCuentaModelo=Tic.NombreTipoCuenta.ToString(),
                        NumeroCuenta=Clie.NumeroCuenta.ToString(),BancoModelo=Banc.NombreBanco.ToString(),Telefono=Clie.Telefono.ToString(),Celular=Clie.Celular.ToString(),Correo=Clie.Correo.ToString(),Ocupacion=Clie.Ocupacion.ToString()};
            return query.ToList();

        }
    }
}