using Microsoft.AspNetCore.Components;
using SuperHeroDB.Shared;
using System.Net.Http.Json;

namespace SuperHeroDB.Client.Services
{
    public class VillainService : IVillainService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public VillainService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public List<Villain> Villains { get; set; } = new List<Villain>();

        public async Task GetVillains()
        {
            var result = await _http.GetFromJsonAsync<List<Villain>>("api/Villain");
            if (result != null)
                Villains = result;
        }

    }
}
