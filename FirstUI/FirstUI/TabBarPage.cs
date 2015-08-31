using System;

using Xamarin.Forms;

namespace FirstUI
{
	public class TabBarPage : ContentPage
	{
		public TabBarPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


