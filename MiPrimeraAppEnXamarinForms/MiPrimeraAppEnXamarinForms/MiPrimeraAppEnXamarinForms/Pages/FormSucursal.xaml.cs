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
	public partial class FormSucursal : ContentPage
	{
		public string tituloForm { get; set; }
		public FormSucursal(string titulo)
		{
			InitializeComponent();
			tituloForm = titulo;
			BindingContext = this;
		}

	

		private void btnRegresar_Clicked(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}
	}
}