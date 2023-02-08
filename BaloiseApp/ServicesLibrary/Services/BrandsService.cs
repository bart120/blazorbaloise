using ServicesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLibrary.Services
{
    public class BrandsService
    {
        private readonly HttpClient http;

        public BrandsService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<List<Brand>> getAllAsync()
        {
            return await http.GetFromJsonAsync<List<Brand>>("brands");
        }

      
    }
}
