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

namespace CarRentalManagement.Client.Pages.Colours
{
    public partial class Index : ComponentBase, IDisposable
    {
        [Inject] private HttpClient _client { get; set; }
        [Inject] private IJSRuntime js { get; set; }
        [Inject] private HttpInterceptorService _interceptor { get; set; }

        private List<Colour> Colours;

        protected override async Task OnInitializedAsync()
        {
            Console.WriteLine("Hitting Code Behind");
            _interceptor.MonitorEvent();
            Colours = await _client.GetFromJsonAsync<List<Colour>>($"{Endpoints.ColoursEndpoint}");
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            js.InvokeVoidAsync("AddDataTable", "#coloursTable");
        }

        void IDisposable.Dispose()
        {
            js.InvokeVoidAsync("DataTablesDispose", "#coloursTable");
        }

        async Task Delete(int colourId)
        {
            var colour = Colours.First(q => q.Id == colourId);

            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {colour.Name}?");
            _interceptor.MonitorEvent();
            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.ColoursEndpoint}/{colourId}");
                await OnInitializedAsync();
            }

        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
