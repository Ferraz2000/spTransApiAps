using APIAPS.Models;
using APIAPS.Repositorio;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace APIAPS.Controllers
{
    public class homeController : ApiController
    {

        // Get api/<controller>/5
        [Route("BuscarLinha/{linha}")]
        [HttpGet]
        public async Task<JArray> BuscarLinha(string linha)
        {
            SpTransController spTransController = new SpTransController();
            var result = await spTransController.BuscarLinhas(linha);
            return result;
        }

        [Route("Parada/{termo}")]
        [HttpGet]
        public async Task<JArray> Parada(string termo)
        {
            SpTransController spTransController = new SpTransController();
            var result = await spTransController.Parada(termo);
            return result;
        }

        [Route("Previsao/{codigoParada}/{codigoLinha}")]
        [HttpGet]
        public async Task<JObject> Parada(string codigoLinha, string codigoParada)
        {
            SpTransController spTransController = new SpTransController();
            var result = await spTransController.Previsao(codigoParada, codigoLinha);
            return result;
        }
    
    }
}