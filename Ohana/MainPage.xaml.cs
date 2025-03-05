using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Geolocation = Xamarin.Essentials.Geolocation;
using Permissions = Xamarin.Essentials.Permissions;
using PermissionStatus = Xamarin.Essentials.PermissionStatus;


namespace Ohana
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CheckLocationPermissions();
        }
        public class EmergencyNotification
        {
            public string UserName { get; set; }
            public string Location { get; set; }
        }
        private async void onSosClicked(object sender, EventArgs e)
        {
            // Get GPS location
            var location = await Geolocation.GetLastKnownLocationAsync();
            string locationString = location != null ? $"{location.Latitude}, {location.Longitude}" : "Location not available";

            // Create emergency notification
            var emergencyNotification = new EmergencyNotification
            {
                UserName = "Unknown", // Replace with actual username if signed in
                Location = locationString
            };

            // Notify PersonnelPage (need to implement a way to communicate)
            MessagingCenter.Send(this, "EmergencyAlert", emergencyNotification);
        }
        private async void CheckLocationPermissions()
        {
            var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();

            if (status != PermissionStatus.Granted)
            {
                status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            }

            if (status == PermissionStatus.Granted)
            {
                // Permissions granted, you can access the location
                await DisplayAlert("Permission Granted", "You can now access location services.", "OK");
                // Example: Get the location
                var location = await Geolocation.GetLastKnownLocationAsync();
                if (location != null)
                {
                    // Use the location (latitude, longitude)
                    Console.WriteLine($"Location: {location.Latitude}, {location.Longitude}");
                }
            }
            else
            {
                // Permissions denied, handle accordingly
                await DisplayAlert("Permission Denied", "Unable to access location services. Please enable permissions in settings.", "OK");
            }
        }
    }
}