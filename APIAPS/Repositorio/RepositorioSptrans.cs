using APIAPS.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace APIAPS.Repositorio
{
    public class RepositorioSptrans
    {
        private static CookieContainer cookieContainer { get; set; }
        #region "metodos publicos"
        public async Task<string> Autenticar()
        {
            var conexao = "http://api.olhovivo.sptrans.com.br/v2.1/Login/Autenticar?token=a2b8503e096053ee9a8706b61c3a0c3ef3753c15267a3e769591c3b4b3a4cb4f";

            // We assume that if the server responds at all, it responds with valid JSON.
            return await ConexaoPost(conexao);
        }

        public async Task<JArray> Parada(string termo)
        {
            var conexao = "http://api.olhovivo.sptrans.com.br/v2.1/Parada/Buscar?termosBusca=" + termo;
            if (cookieContainer == null)
            {
                await Autenticar();
            }
            var json = await ConexaoGet(conexao);
            dynamic str = JsonConvert.DeserializeObject(json);
            return str;
        }
        public async Task<JArray> BuscaLinha(string linha)
        {
            var conexao = "http://api.olhovivo.sptrans.com.br/v2.1/Linha/Buscar?termosBusca=" + linha;
            if (cookieContainer == null)
            {
                await Autenticar();
            }
            var json = await ConexaoGet(conexao);
            dynamic str = JsonConvert.DeserializeObject(json);
            return str;

        }
        public async Task<JObject> PrevisaoPorLinhaeParada(string codigoParada, string codigoLinha)
        {
            var conexao = "http://api.olhovivo.sptrans.com.br/v2.1/Previsao?codigoParada=" + codigoParada + "&codigoLinha=" + codigoLinha;
            if (cookieContainer == null)
            {
                await Autenticar();
            }
            var json = await ConexaoGet(conexao);
            dynamic str = JsonConvert.DeserializeObject(json);
            return str;
        }

        #endregion
        #region "metodos privados"


        private async Task<string> ConexaoGet(String conexao)
        {
            var handler = getHttpHandler();
            HttpClient httpClient = new HttpClient(handler);
            HttpResponseMessage httpResponse = null;

            httpResponse = await httpClient.GetAsync(conexao);
            if (!httpResponse.IsSuccessStatusCode)
            {
                return "Erro de comunicação com o servidor";
            }

            // We assume that if the server responds at all, it responds with valid JSON.
            return await httpResponse.Content.ReadAsStringAsync();
        }
        private async Task<string> ConexaoPost(string conexao)
        {
            HttpContent content = null;
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage httpResponse = null;
            httpResponse = await httpClient.PostAsync(conexao, content);
            readCookies(httpResponse, conexao);

            // We assume that if the server responds at all, it responds with valid JSON.
            return await httpResponse.Content.ReadAsStringAsync();
        }
        private void readCookies(HttpResponseMessage response, string url)
        {
            var pageUri = new Uri(url);

            IEnumerable<string> cookies;
            if (response.Headers.TryGetValues("Set-Cookie", out cookies))
            {
                cookieContainer = new CookieContainer();

                foreach (var c in cookies)
                {
                    cookieContainer.SetCookies(pageUri, c);
                }
            }
        }
        private HttpClientHandler getHttpHandler()
        {
            var handler = new HttpClientHandler();

            if (cookieContainer != null)
            {
                handler.CookieContainer = cookieContainer;
            }

            return handler;
        }
        #endregion
    }
}