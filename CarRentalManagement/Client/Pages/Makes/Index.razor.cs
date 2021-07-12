using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace CarRentalManagement.Client.Pages.Makes
{
    public partial class Index
    {
        [Inject] private HttpClient _client { get; set; }
        [Inject] private IJSRuntime js { get; set; }
        [Inject] private HttpInterceptorService _interceptor { get; set; }

        private List<Make> Makes;

        protected override async Task OnInitializedAsync()
        {
            _interceptor.MonitorEvent(); 
            Makes = await _client.GetFromJsonAsync<List<Make>>($"{Endpoints.MakesEndpoint}");

        }

        async Task Delete(int makeId)
        {
            var make = Makes.First(q => q.Id == makeId);

            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {make.Name}?");

            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.MakesEndpoint}/{makeId}");
                await OnInitializedAsync();
            }

        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
