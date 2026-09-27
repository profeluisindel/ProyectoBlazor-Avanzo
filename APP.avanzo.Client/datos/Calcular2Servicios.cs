using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace APP.avanzo.Client.datos
{
    public class Calcular2Servicios
    {
        private readonly HttpClient _http;

        public Calcular2Servicios(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Calcular2>> Listar()
        {
            return await _http.GetFromJsonAsync<List<Calcular2>>("api/calculos") ?? new List<Calcular2>();
        }
    }
}