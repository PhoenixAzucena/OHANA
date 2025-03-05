using System.Collections.ObjectModel;

namespace Ohana
{
    public partial class PersonnelPage : ContentPage
    {
        public class EmergencyNotification
        {
            public required string UserName { get; set; }
            public required string Location { get; set; }
        }
        public ObservableCollection<EmergencyNotification> EmergencyNotifications { get; set; }

        public PersonnelPage()
        {
            InitializeComponent();
            EmergencyNotifications = new ObservableCollection<EmergencyNotification>();
            // Example: Bind the list to a ListView or similar control
            // MyListView.ItemsSource = EmergencyNotifications;

            MessagingCenter.Subscribe<MainPage, EmergencyNotification>(this, "EmergencyAlert", (sender, notification) =>
            {
                EmergencyNotifications.Add(notification);
                // Update UI if necessary
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            // Unsubscribe when the page is no longer visible
            MessagingCenter.Unsubscribe<MainPage, EmergencyNotification>(this, "EmergencyAlert");
        }
    }
}