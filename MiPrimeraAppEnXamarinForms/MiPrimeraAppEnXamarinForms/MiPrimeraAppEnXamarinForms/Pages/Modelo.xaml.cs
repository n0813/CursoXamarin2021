using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiPrimeraAppEnXamarinForms.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Modelo : ContentPage
	{
		public Modelo()
		{
			InitializeComponent();
		}

		private void toolbarRegistrar_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new FormModelo("Registrar Modelo"));
		}

		private void toolbarVer_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new FormModelo("Ver Modelo"));
		}
	}
}