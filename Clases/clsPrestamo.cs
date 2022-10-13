using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NatilleraApi.Clases
{
    public class clsPrestamo
    {
        public Prestamo prestamo { get; set; }
        private NatilleraEntities Natillera = new NatilleraEntities();

        public void Insertar()
        {
            prestamo.ValorTotalPrestamo = prestamo.ValorPrestado * (prestamo.InteresPor / 100) + prestamo.ValorPrestado;
            Natillera.Prestamo.Add(prestamo);
            Natillera.SaveChanges();
        }
        public void Eliminar()
        {
            Prestamo OPrestamo = Natillera.Prestamo.Where(x => x.IDPrestamo == prestamo.IDPrestamo).FirstOrDefault();
            Natillera.Prestamo.Remove(OPrestamo);
            Natillera.SaveChanges();
        }
        public void Actualizar()
        {
            Prestamo OPrestamo = Natillera.Prestamo.Where(x => x.IDPrestamo == prestamo.IDPrestamo).FirstOrDefault();
            OPrestamo.FechaPrestamo = prestamo.FechaPrestamo;
            OPrestamo.ValorPrestado = prestamo.ValorPrestado;
            OPrestamo.InteresPor = prestamo.InteresPor;
            OPrestamo.ValorTotalPrestamo = prestamo.ValorPrestado * (prestamo.InteresPor / 100) + prestamo.ValorPrestado;
            OPrestamo.IDCliente = prestamo.IDCliente;
            Natillera.SaveChanges();
        }
        public Prestamo ConsultaXID(int Prestamo)
        {
            return Natillera.Prestamo.Where(p => p.IDPrestamo == Prestamo).FirstOrDefault();
        }
        public List<Prestamo> ConsultaTodos()
        {

            return Natillera.Prestamo.ToList();
        }


    }
}