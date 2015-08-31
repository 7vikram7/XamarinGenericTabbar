using System;

using Xamarin.Forms;

namespace FirstUI
{
	public class SuccessPage : ContentPage
	{
		public SuccessPage ()
		{
			
			Content = new StackLayout { 
				Children = {
					new Label { Text = "This is Sparta" }
				}
			};


		}
	}
}


