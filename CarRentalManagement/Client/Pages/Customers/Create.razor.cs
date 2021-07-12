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

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Create : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] private HttpInterceptorService _interceptor { get; set; }

        Customer customer = new Customer();

        private IList<Customer> Customers;
        protected override async Task OnInitializedAsync()
        {
            //Customers = await _client.GetFromJsonAsync<List<Customer>>($"{Endpoints.CustomersEndpoint}");
        }

        private async Task CreateCustomer()
        {

            _interceptor.MonitorEvent();
            await _client.PostAsJsonAsync(Endpoints.CustomersEndpoint, customer);
            _navManager.NavigateTo("/customers/");
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
