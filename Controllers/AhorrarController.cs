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
    public class AhorrarController : ApiController
    {
        [EnableCors(origins: "http://localhost:50072", headers: "*", methods: "*")]
        public List<Ahorro> Get()
        {
            clsAhorro Ahorro = new clsAhorro();
            return Ahorro.ConsultaTodos();
        }

        // GET api/<controller>/5
        public Ahorro Get(int AhorroID)
        {

            clsAhorro OAhorro = new clsAhorro();
            return OAhorro.ConsultaXID(AhorroID);
        }

        // POST api/<controller>
        public string Post([FromBody] Ahorro ahorro)
        {
            try
            {
                clsAhorro oAhorro = new clsAhorro();
                oAhorro.ahorro = ahorro;
                oAhorro.Insertar();
                return "Se ha Insertado Correctamente";
            }

            catch (Exception ex) { return ex.Message; }
        }

        // PUT api/<controller>/5
        public string Put([FromBody] Ahorro ahorro)
        {
            try
            {
                clsAhorro oAhorro = new clsAhorro();
                oAhorro.ahorro = ahorro;
                oAhorro.Actualizar();
                return "Se Ha Actualizado Correctamente";
            }

            catch (Exception ex) { return ex.Message; }
        }

        // DELETE api/<controller>/5
        public string Delete(Ahorro ahorro)
        {
            try
            {
                clsAhorro oAhorro = new clsAhorro();
                oAhorro.ahorro = ahorro;
                oAhorro.Eliminar();
                return "Se Ha Eliminado COrrectamente";
            }

            catch (Exception ex) { return ex.Message; }
        }
    }
}