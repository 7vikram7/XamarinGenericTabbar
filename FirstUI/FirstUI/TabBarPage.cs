using System;

using Xamarin.Forms;

namespace FirstUI
{
	public class TabBarPage : ContentPage
	{

		Button Tab1Button;

		Button Tab2Button;

		SuccessPage SuccessPage = new SuccessPage();

		RegisterViewController RegisterViewController = new RegisterViewController();

		RelativeLayout CurrentRelativeLayout;


		public TabBarPage ()
		{
			CurrentRelativeLayout = new RelativeLayout{
				Padding = new Thickness(0,Device.OnPlatform(20,0,0),0,0)
			};
			Content = CurrentRelativeLayout;

			CreateUI ();

		}

		private void CreateUI() {

			CreateTab1Button ();
			CreateTab2Button ();

			CreateChildSuccessPage ();
			CreateChildRegisterPage ();


		}


		private void CreateTab1Button() {

			Tab1Button = new Button();
			Tab1Button.BackgroundColor = Color.Lime;
			Tab1Button.Text = "Tab1";
			Tab1Button.Clicked += (object sender, EventArgs e) => Tab1Tapped(sender, e);
			CurrentRelativeLayout.Children.Add (Tab1Button,
				Constraint.Constant(0),
				Constraint.Constant(20),
				Constraint.RelativeToParent ((parent)=> {
					return parent.Width/2;
				}),
				Constraint.Constant(64)

			
			);


		}

		private void CreateTab2Button() {

			Tab2Button = new Button();
			Tab2Button.BackgroundColor = Color.Lime;
			Tab2Button.Text = "Tab2";
			Tab2Button.Clicked += (object sender, EventArgs e) => Tab2Tapped(sender, e);
			CurrentRelativeLayout.Children.Add (Tab2Button,
				Constraint.RelativeToParent ((parent)=> {
					return parent.Width/2;
				}),
				Constraint.Constant(20),

				Constraint.RelativeToParent ((parent)=> {
					return parent.Width/2;
				}),
				Constraint.Constant(64)

			);

		}

		private void CreateChildSuccessPage() {
			SuccessPage.Content.IsVisible = false;
			CurrentRelativeLayout.Children.Add(SuccessPage.Content,
				Constraint.Constant(0),
				Constraint.Constant(84),
				Constraint.RelativeToParent ((parent)=> {
					return parent.Width;
				}),
				Constraint.RelativeToParent ((parent)=> {
					return parent.Height - 64;
				})
			);

		}

		private void CreateChildRegisterPage() {

			CurrentRelativeLayout.Children.Add(RegisterViewController.Content,
				Constraint.Constant(0),
				Constraint.Constant(84),
				Constraint.RelativeToParent ((parent)=> {
					return parent.Width;
				}),
				Constraint.RelativeToParent ((parent)=> {
					return parent.Height - 64;
				})
			);

		}

		public void Tab1Tapped (object sender, EventArgs e){

			SuccessPage.Content.IsVisible = false;
			RegisterViewController.Content.IsVisible = true;

		}

		public void Tab2Tapped (object sender, EventArgs e){

			SuccessPage.Content.IsVisible = true;
			RegisterViewController.Content.IsVisible = false;


		}





	}
}


