using System.Net.Http.Json;
using GymTrainerGuide.Shared.Entities;

namespace GymTrainerGuide.Web.Repositories
{
    public class RutinaRepository
    {
        private readonly HttpClient _http;

        public RutinaRepository(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Rutina>> GetRutinasAsync()
        {
            var result = await _http.GetFromJsonAsync<List<Rutina>>("Rutinas");
            return result ?? new List<Rutina>();
        }
    }
}
