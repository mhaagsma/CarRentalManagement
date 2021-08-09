using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Create 
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] private HttpInterceptorService _interceptor { get; set; }
        [Inject] IHttpRepository<Customer> _clientREPO { get; set; }
        Customer customer = new Customer();

        private IList<Customer> Customers;
        //protected override async Task OnInitializedAsync()
        //{
        //    //Customers = await _client.GetFromJsonAsync<List<Customer>>($"{Endpoints.CustomersEndpoint}");
        //}

        private async Task CreateCustomer()
        {

            await _clientREPO.Create(Endpoints.CustomersEndpoint, customer);
            // await _client.PostAsJsonAsync(Endpoints.CustomersEndpoint, customer);
            _navManager.NavigateTo("/customers/");
        }
    }
}
