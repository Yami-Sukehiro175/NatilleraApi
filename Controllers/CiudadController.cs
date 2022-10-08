using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using NatilleraApi.Models;
using NatilleraApi.Clases;


namespace NatilleraApi.Controllers
{
    public class CiudadController : ApiController
    {
        [EnableCors(origins: "http://localhost:50072", headers: "*", methods: "*")]
        // GET api/<controller>
        public List<viewCombos> Get()
        {

            clsCiudad oCiudad = new clsCiudad();
            return oCiudad.LlenarComboCiudad();
        }
    }
}