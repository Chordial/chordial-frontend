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

		async void OnClickSwaghil(object sender, EventArgs e)
		{
			await this.DisplayAlert("Swaghil!", "Is Swaghil the best?", "Yes", "Yes \ud83d\ude0e");
		}

		async void OnClickZiv(object sender, EventArgs e)
		{
			var response = await this.DisplayAlert("Important Question", "Is the cake a lie? \uD83C\uDF82", "Yes", "No");
			if (response){
				await this.DisplayAlert("", "Fine, no cake for you.", ":(");
			}
			else {
				await this.DisplayAlert("", "Good.", ":)");
			}

		}


	}
}
