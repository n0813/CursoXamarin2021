using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MiPrimeraAppEnXamarinForms
{
	public partial class MainPage : ContentPage
	{
	  public string nombreusuario { get; set; }
	  public string contra { get; set; }
		public MainPage()
		{
			InitializeComponent();
			BindingContext = this;
		}

		private void btnIniciar_Clicked(object sender, EventArgs e)
		{
			//Todo lo que esta aca
			if (nombreusuario == "lhurol" && contra == "1234")
				Application.Current.MainPage = new PaginaPrincipal();
			else
				DisplayAlert("Error", "Usuario o clave incorrecta", "Cancelar");
		}

		private void btnRegistrar_Clicked(object sender, EventArgs e)
		{
			//Todo lo que escribas
			Navigation.PushAsync(new PaginaRegistro());
		}
	}
}
