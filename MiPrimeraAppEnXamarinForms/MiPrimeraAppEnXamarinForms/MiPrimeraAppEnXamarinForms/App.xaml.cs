using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MiPrimeraAppEnXamarinForms.Pages;
namespace MiPrimeraAppEnXamarinForms
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage( new Marca());
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
