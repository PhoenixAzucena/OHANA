using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace Ohana
{
    public partial class SettingsPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public SettingsPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "App Theme",
                "Hardware Device",
                "Alert Notifications",
                "Location Sharing",
                "User Guide",
                "Version Information"

            };

            MyListView.ItemsSource = Items;
        }

        private async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var selectedItem = e.Item as string;
                // Handle the selected item
                await DisplayAlert("Selected", selectedItem, "OK");
                MyListView.SelectedItem = null; // Deselect the item
            }
        }
    }
}