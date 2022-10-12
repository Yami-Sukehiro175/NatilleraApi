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
    public class ClienteController : ApiController
    {
        [EnableCors(origins: "http://localhost:50072", headers: "*", methods: "*")]
        // GET api/<controller>
        public List<ClienteLista> Get()
        {
            clsCliente oCliente = new clsCliente();
            return oCliente.ListarClientes();
        }
        public List<viewCombos>  Get(string Combo) {
            
            clsCliente Cliente = new clsCliente();
            return Cliente.LlenarComboCliente();
            
        }

    }
}