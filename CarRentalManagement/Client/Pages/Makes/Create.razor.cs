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

namespace CarRentalManagement.Client.Pages.Makes
{
    public partial class Create : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] private HttpInterceptorService _interceptor { get; set; }

        Make make = new Make();


        private async Task CreateMake()
        {
            _interceptor.MonitorEvent(); 
            await _client.PostAsJsonAsync(Endpoints.MakesEndpoint, make);
            _navManager.NavigateTo("/makes/");
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
