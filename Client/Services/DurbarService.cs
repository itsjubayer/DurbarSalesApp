using DurbarSalesApp.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace DurbarSalesApp.Client.Services
{
    public class DurbarService : IDurbarService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;


        public DurbarService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public List<GenerateList> GenerateList { get; set; } = new List<GenerateList>();


        /// <summary>
        /// Request
        /// </summary>
        /// <returns></returns>
        public async Task GetList()
        {
            var result = await _http.GetFromJsonAsync<List<GenerateList>>("api/Durbar/GetList");
            if (result != null)
            {
                GenerateList = result;
            }
        }
    }
}
