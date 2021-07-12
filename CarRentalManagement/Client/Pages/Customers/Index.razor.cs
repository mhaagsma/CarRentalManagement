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

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Index
    {
        [Inject] private HttpClient _client { get; set; }
        [Inject] private IJSRuntime js { get; set; }
        [Inject] private HttpInterceptorService _interceptor { get; set; }


        private List<Customer> Customers;

        protected override async Task OnInitializedAsync()
        {
            _interceptor.MonitorEvent(); 
            Customers = await _client.GetFromJsonAsync<List<Customer>>($"{Endpoints.CustomersEndpoint}");
        }

        async Task Delete(int customerId)
        {
            var customer = Customers.First(q => q.Id == customerId);

            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {customer.Id}?");

            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.CustomersEndpoint}/{customerId}");
                await OnInitializedAsync();
            }

        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
