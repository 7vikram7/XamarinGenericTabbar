using System;

using Xamarin.Forms;

namespace FirstUI
{
	public class App : Application
	{
//		NavigationPage MainNavigationController;

		Button Dipesh = new Button {
			Text = "Dipesh Rocks"

		};

		public App ()
		{

//			MainPage = new RegisterViewController();

			MainPage = new NavigationPage(new RegisterViewController());

//			Dipesh.Clicked += (object sender, EventArgs e) => DipeshTapped(sender, e);
//
//			// The root page of your application
//			MainPage = new ContentPage {
//				Content = new StackLayout {
//					VerticalOptions = LayoutOptions.Center,
//					Children = {
//						new Label {
//							XAlign = TextAlignment.Center,
//							Text = "Welcome to Xamarin Forms!"
//						}, new StackLayout{
//
//
//
//
//							VerticalOptions = LayoutOptions.Center,
//							Children = {
//
//								Dipesh
//							}
//
//						}
//
//					}
//				}
//			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

		public void DipeshTapped (object sender, EventArgs e){



			Dipesh.Text = "Dipesh says he indeed rocks";

		}
	}
}

