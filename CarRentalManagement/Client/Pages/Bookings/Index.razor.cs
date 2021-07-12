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

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class Index
    {

        [Inject] private HttpClient _client { get; set; }
        [Inject] private IJSRuntime js { get; set; }

        [Inject] private HttpInterceptorService _interceptor { get; set; }

        private List<Booking> Bookings;

        protected override async Task OnInitializedAsync()
        {
            _interceptor.MonitorEvent(); 
            Bookings = await _client.GetFromJsonAsync<List<Booking>>($"{Endpoints.BookingsEndpoint}");
        }

        async Task Delete(int bookingId)
        {
            var booking = Bookings.First(q => q.Id == bookingId);

            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {booking.Id}?");

            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.BookingsEndpoint}/{bookingId}");
                await OnInitializedAsync();
            }

        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
