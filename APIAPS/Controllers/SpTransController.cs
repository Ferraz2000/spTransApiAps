using APIAPS.Models;
using APIAPS.Repositorio;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace APIAPS.Controllers
{

    public class SpTransController
    {
        private readonly RepositorioSptrans _repositorioSptrans;
        public SpTransController()
        {
            _repositorioSptrans = new RepositorioSptrans();

        }

        public async Task<string> Autenticar()
        {
            var autenticado = await _repositorioSptrans.Autenticar();
            if (autenticado == "false")
                return "usuário não autenticado";

            return "usuário autenticado!";
        }

        public async Task<JArray> BuscarLinhas(string linha)
        {
            var linhas = await _repositorioSptrans.BuscaLinha(linha);
            return linhas;

        }

        public async Task<JArray> Parada(string linha)
        {
            var linhas = await _repositorioSptrans.Parada(linha);
            return linhas;

        }
        public async Task<JObject> Previsao(string codigoParada ,string codigoLinha)
        {
            var linhas = await _repositorioSptrans.PrevisaoPorLinhaeParada(codigoParada, codigoLinha);
            return linhas;

        }
    }
}