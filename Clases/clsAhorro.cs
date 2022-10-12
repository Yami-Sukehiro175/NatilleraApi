using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NatilleraApi.Clases
{
    public class clsAhorro
    {
        public Ahorro ahorro { get; set; }
        private NatilleraEntities Natillera = new NatilleraEntities();

        public void Insertar() {
            Natillera.Ahorro.Add(ahorro);
            Natillera.SaveChanges();
        }
        public void Eliminar()
        {
            Ahorro OAhorro = Natillera.Ahorro.Where(x => x.IDAhorro == ahorro.IDAhorro).FirstOrDefault();
            Natillera.Ahorro.Remove(OAhorro);
            Natillera.SaveChanges();
        }
        public void Actualizar()
        {
            Ahorro OAhorro = Natillera.Ahorro.Where(x => x.IDAhorro == ahorro.IDAhorro).FirstOrDefault();
            OAhorro.FechaAhorro = ahorro.FechaAhorro;
            OAhorro.ValorAhorrado = ahorro.ValorAhorrado;
            OAhorro.IDCliente = ahorro.IDCliente;
            Natillera.SaveChanges();
        }
        public Ahorro ConsultaXID(int Ahorro)
        {
            return Natillera.Ahorro.Where(p => p.IDAhorro == Ahorro).FirstOrDefault();
}
        public List<Ahorro> ConsultaTodos() {

            return Natillera.Ahorro.ToList();
        }


    }
}