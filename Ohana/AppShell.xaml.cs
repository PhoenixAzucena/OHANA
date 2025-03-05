namespace Ohana
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(PersonnelPage), typeof(PersonnelPage));
        }
    }
}
