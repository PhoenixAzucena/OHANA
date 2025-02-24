using System;
using Microsoft.Maui.Controls;
namespace Ohana
{


	public partial class ProfilePage : ContentPage
	{
		public ProfilePage()
		{
			InitializeComponent();
		}
		private async void OnGoBackClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}