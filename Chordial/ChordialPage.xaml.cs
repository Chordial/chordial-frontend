using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chordial
{
	public partial class ChordialPage : ContentPage
	{
		public ChordialPage()
		{
			InitializeComponent();
		}

		async void OnClickRick(object sender, EventArgs e)
		{
			await this.DisplayAlert("Kawaii", "Are hamsters the best?", "Yes", "Yes \ud83d\udc39");
		}

		// Put your OnClick functions for your buttons below here. Use my example!


	}
}
