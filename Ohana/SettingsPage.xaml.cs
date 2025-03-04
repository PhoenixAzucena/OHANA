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
<<<<<<< HEAD
                "Terms and Conditions",
                "Version Information"
            };

            MyListView.ItemsSource = Items;

            // Customize ListView Item Template
            MyListView.ItemTemplate = new DataTemplate(() =>
            {
                var label = new Label
                {
                    FontSize = 20, // Set font size
                    TextColor = Colors.Black, // Set font color
                    VerticalOptions = LayoutOptions.Center
                };
                label.SetBinding(Label.TextProperty, ".");

                var stackLayout = new StackLayout
                {
                    Padding = 10,
                    HeightRequest = 50, // Set item height
                    Children = { label }
                };

                return new ViewCell { View = stackLayout };
            });
        }
=======
                "Version Information"

            };

            MyListView.ItemsSource = Items;
        }

>>>>>>> eddaef0a6856b210e8fba47de03fff615876c826
        private async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                var selectedItem = e.Item as string;
<<<<<<< HEAD
                Page? nextPage = null;

                // Determine which page to navigate to based on the selected item
                switch (selectedItem)
                {
                    case "App Theme":
                        nextPage = new AppThemePage();
                        break;
                    case "Hardware Device":
                        nextPage = new HardwareDevicePage();
                        break;
                    case "Alert Notifications":
                        nextPage = new AlertNotificationsPage();
                        break;
                    case "Location Sharing":
                        nextPage = new LocationSharingPage();
                        break;
                    case "User Guide":
                        nextPage = new UserGuidePage();
                        break;
                    case "Terms and Conditions":
                        nextPage = new TermsAndConditionsPage();
                        break;
                    case "Version Information":
                        nextPage = new VersionInformationPage();
                        break;
                }

                // Navigate to the selected page if it exists
                if (nextPage != null)
                {
                    await Navigation.PushAsync(nextPage);
                }

=======
                // Handle the selected item
                await DisplayAlert("Selected", selectedItem, "OK");
>>>>>>> eddaef0a6856b210e8fba47de03fff615876c826
                MyListView.SelectedItem = null; // Deselect the item
            }
        }
    }
}
