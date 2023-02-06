using BaloiseApp.Models;
using System.Net.Http.Json;

namespace BaloiseApp.Services
{
    public class CarsService
    {
        private readonly HttpClient http;

        public CarsService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<List<Car>> getAllAsync()
        {
            return await http.GetFromJsonAsync<List<Car>>("cars");
        }

        public async Task<Car> getByIdAsync(int id)
        {
            return await http.GetFromJsonAsync<Car>($"cars/{id}");
        }
    }
}
