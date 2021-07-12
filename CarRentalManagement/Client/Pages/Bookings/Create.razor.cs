using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Bookings
{
 
    public partial class Create : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject]  NavigationManager _navManager { get; set; }
        [Inject] private HttpInterceptorService _interceptor { get; set; }

        Booking booking = new Booking
        {
            DateOut = DateTime.Now.Date
        };


        private async Task CreateBooking()
        {
            _interceptor.MonitorEvent(); 
            await _client.PostAsJsonAsync(Endpoints.BookingsEndpoint, booking);
            _navManager.NavigateTo("/bookings/");
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
