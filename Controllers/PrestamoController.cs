using NatilleraApi.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NatilleraApi.Controllers
{
    public class PrestamoController : ApiController
    {
        [EnableCors(origins: "http://localhost:50072", headers: "*", methods: "*")]
        public List<Prestamo> Get()
        {
            clsPrestamo Prestamo = new clsPrestamo();
            return Prestamo.ConsultaTodos();
        }

        // GET api/<controller>/5
        public Prestamo Get(int PrestamoID)
        {

            clsPrestamo Prestamo = new clsPrestamo();
            return Prestamo.ConsultaXID(PrestamoID);
        }

        // POST api/<controller>
        public string Post([FromBody] Prestamo prestamo)
        {
            try
            {
                clsPrestamo Prestamo = new clsPrestamo();
                Prestamo.prestamo = prestamo;
                Prestamo.Insertar();
                return "Se ha Insertado Correctamente";
            }

            catch (Exception ex) { return ex.Message; }
        }

        // PUT api/<controller>/5
        public string Put([FromBody] Prestamo prestamo)
        {
            try
            {
                clsPrestamo Prestamo = new clsPrestamo();
                Prestamo.prestamo = prestamo;
                Prestamo.Actualizar();
                return "Se Ha Actualizado Correctamente";
            }

            catch (Exception ex) { return ex.Message; }
        }

        // DELETE api/<controller>/5
        public string Delete(Prestamo prestamo)
        {
            try
            {
                clsPrestamo Prestamo = new clsPrestamo();
                Prestamo.prestamo = prestamo;
                Prestamo.Eliminar();
                return "Se Ha Eliminado COrrectamente";
            }

            catch (Exception ex) { return ex.Message; }
        }
    }
}