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
	public partial class Sucursal : ContentPage
	{
		public Sucursal()
		{
			InitializeComponent();
		}

		private void toolbarRegistrar_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new FormSucursal("Registrar Sucursal"));
		}

		private void toolbarVer_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new FormSucursal("Ver Sucursal"));
		}
	}
}