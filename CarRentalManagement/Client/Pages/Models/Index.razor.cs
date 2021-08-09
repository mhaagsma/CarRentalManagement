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

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Index : ComponentBase, IDisposable
    {
        [Inject] private HttpClient _client { get; set; }
        [Inject] private IJSRuntime js { get; set; }
        [Inject] private HttpInterceptorService _interceptor { get; set; }

        private List<Model>? Models;

        protected override async Task OnInitializedAsync()
        {
            _interceptor.MonitorEvent(); 
            Models = await _client.GetFromJsonAsync<List<Model>>($"{Endpoints.ModelsEndpoint}");
        }
        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            js.InvokeVoidAsync("AddDataTable", "#modelsTable");
        }

        void IDisposable.Dispose()
        {
            js.InvokeVoidAsync("DataTablesDispose", "#modelsTable");
        }
        async Task Delete(int modelId)
        {
            var model = Models.First(q => q.Id == modelId);

            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {model.Name}?");

            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.ModelsEndpoint}/{modelId}");
                await OnInitializedAsync();
            }

        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
