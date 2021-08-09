using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class View
    {
        [Inject] IHttpRepository<Vehicle> _clientRepo { get; set; }
        [Inject] private NavigationManager _navManager { get; set; }
        [Inject] private HttpInterceptorService _interceptor { get; set; }
        [Parameter] public int id { get; set; }

        Vehicle vehicle = new Vehicle();

        protected override async Task OnParametersSetAsync()
        {
            vehicle = await _clientRepo.GetDetails(Endpoints.VehiclesEndpoint, id);
        }
    }
}
