using NatilleraApi.Clases;
using NatilleraApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NatilleraApi.Controllers
{
    public class CamposController : ApiController
    {
        [EnableCors(origins: "http://localhost:50072", headers: "*", methods: "*")]
        // GET api/<controller>
        public List<ColeccionTexto> Get(string Documento)
        {

            clsCliente oCliente = new clsCliente();
            return oCliente.LLenarDatosCamposCliente(Documento);
        }
        
            public List<ClienteListaAhorro> Get()
            {
                clsCampos OCampos = new clsCampos();
                return OCampos.ListarClientes();
            }
        }

      
    }
