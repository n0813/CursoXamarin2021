using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WFormWebApi.Classes;

namespace WFormWebApi.Assets
{
    public class ConexionApi
    {

        string stURL = "http://10.10.1.95:9696/";     //pruebas
        //string stURL = "http://189.206.114.109:8080/";  //produccion

        //api/marca
        public async Task<List<T>> ObtenerTodo<T>(string stRuta)
        {
            try
            {
                HttpClient cliente = new HttpClient();
                var rpta = await cliente.GetAsync(stURL + stRuta);
                
                if (!rpta.IsSuccessStatusCode)
                {
                    return new List<T>();
                }
                else
                {
                    var result = await rpta.Content.ReadAsStringAsync();
                    List<T> json = JsonConvert.DeserializeObject<List<T>>(result);
                    return json;
                }

            }
            catch (Exception ex)
            {
                string a = "";
                return null;
            }

        }

        //api/marca/23
        public async Task<T> ObtenerRegistro<T>(string stRuta)
        {
                HttpClient cliente = new HttpClient();
                var rpta = await cliente.GetAsync(stURL + stRuta);

                var result = await rpta.Content.ReadAsStringAsync();
                T json = JsonConvert.DeserializeObject<T>(result);
                return json;


        }

        //api/marca
        public async Task<int> AgregarActualizar<T>(string stRuta ,T obj)
        {
            HttpClient client = new HttpClient();
            string url = stURL + stRuta ;
            var vCadena = JsonConvert.SerializeObject(obj);
            var body = new StringContent(vCadena, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, body);
            if (!response.IsSuccessStatusCode)
            {
                return 0;
            }
            else
            {
                int respuesta = int.Parse(await response.Content.ReadAsStringAsync());
                return respuesta;
            }
        }

        public async Task<int> Eliminar(string stRuta)
        {
            HttpClient client = new HttpClient();
            var resp = await client.DeleteAsync(stURL + stRuta);
            if (!resp.IsSuccessStatusCode)
            {
                return 0;

            }
            else
            {
                var resultado = await resp.Content.ReadAsStringAsync();
                return int.Parse(resultado);
            }

        }
    }
}
