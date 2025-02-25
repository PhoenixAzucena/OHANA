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
                "Item 1",
                "Item 2",
                "Item 3"
            };

            MyListView.ItemsSource = Items;
        }

        private async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var selectedItem = e.Item as string;
                // Handle the selected item
          
                MyListView.SelectedItem = null; // Deselect the item
            }
        }
    }
}