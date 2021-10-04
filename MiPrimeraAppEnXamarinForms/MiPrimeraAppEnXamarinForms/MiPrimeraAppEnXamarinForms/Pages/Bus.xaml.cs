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
	public partial class Bus : ContentPage
	{
		public Bus()
		{
			InitializeComponent();
		}

		private void toolbarVer_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new FormBus("Ver Bus"));
		}

		private void toolbarNuevo_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new FormBus("Nuevo Bus"));
		}
	}
}