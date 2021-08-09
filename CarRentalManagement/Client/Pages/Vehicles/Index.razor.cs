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

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Index : ComponentBase, IDisposable
    {
        [Inject] private HttpClient _client { get; set; }
        [Inject] private IJSRuntime js { get; set; }
        [Inject] private HttpInterceptorService _interceptor { get; set; }

        private List<Vehicle> Vehicles;

        protected override async Task OnInitializedAsync()
        {
            _interceptor.MonitorEvent(); 
            Vehicles = await _client.GetFromJsonAsync<List<Vehicle>>($"{Endpoints.VehiclesEndpoint}");
        }
        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            js.InvokeVoidAsync("AddDataTable", "#vehiclesTable");
        }

        void IDisposable.Dispose()
        {
            js.InvokeVoidAsync("DataTablesDispose", "#vehiclesTable");
        }
        async Task Delete(int vehicleId)
        {
            var vehicle = Vehicles.First(q => q.Id == vehicleId);

            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {vehicle.Id}?");

            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.VehiclesEndpoint}/{vehicleId}");
                await OnInitializedAsync();
            }

        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }


}
