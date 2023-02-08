
using ServicesLibrary.Models;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ServicesLibrary.Services
{
    public class CarsService
    {
        private readonly HttpClient http;

        public CarsService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<List<Car>> GetAllAsync()
        {
            return await http.GetFromJsonAsync<List<Car>>("cars");
        }

        public async Task<Car> GetByIdAsync(int id)
        {
            return await http.GetFromJsonAsync<Car>($"cars/{id}");
        }

        public async Task<Car?> InsertAsync(Car car)
        {
            var resp = await http.PostAsJsonAsync("cars", car);
            if (resp.IsSuccessStatusCode)
            {
                return await  resp.Content.ReadFromJsonAsync<Car>();
            }
            else
            {
                return null;
            }
        }

        public async Task DeleteAsync(int id)
        {
            await http.DeleteAsync($"cars/{id}");
        }
    }
}
