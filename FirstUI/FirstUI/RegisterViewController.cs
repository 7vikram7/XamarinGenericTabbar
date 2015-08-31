using System;

using Xamarin.Forms;

namespace FirstUI
{
	public class RegisterViewController : ContentPage
	{

		Label TitleLabel;

		Entry FirstNameEntry;

		Entry LastNameEntry;

		Entry ExperienceEntry;

		Label AddressLabel;

		Editor AddressEditor;

		Button ClearButton;

		Button SaveButton;

		SuccessPage SuccessPage = new SuccessPage();


		StackLayout CurrentStackLayout;

		

		public RegisterViewController ()
		{
			CurrentStackLayout = new StackLayout{
				Padding = new Thickness(0,Device.OnPlatform(20,0,0),0,0)
			};
			Content = CurrentStackLayout;


			CreateUI ();
		}



		private void CreateUI() {

			CreateTitleLabel();
			CreateFirstNameEntry();
			CreateLastNameEntry ();
			CreateExperienceEntry ();
			CreateAddressLabel ();
			CreateAddressEditor	();
			CreateClearButton ();
			CreateSaveButton ();

//			CreateChildSuccessPage ();

		
		}

		private void CreateTitleLabel() {

			TitleLabel = new Label();
			TitleLabel.Text = "Volunteer Student Registration";
			TitleLabel.FontSize = 20;
			TitleLabel.TextColor = Color.Blue;
			TitleLabel.XAlign = TextAlignment.Center;
			CurrentStackLayout.Children.Add (TitleLabel);	
		}

		private void CreateFirstNameEntry() {

			FirstNameEntry = new Entry();
			FirstNameEntry.Placeholder = "First Name";
			CurrentStackLayout.Children.Add (FirstNameEntry);	

		}

		private void CreateLastNameEntry() {

			LastNameEntry = new Entry();
			LastNameEntry.Placeholder = "Last Name";
			CurrentStackLayout.Children.Add (LastNameEntry);	

		}

		private void CreateExperienceEntry() {

			ExperienceEntry = new Entry();
			ExperienceEntry.Placeholder = "Experience in Months";
			CurrentStackLayout.Children.Add (ExperienceEntry);	

		}
			
		private void CreateAddressLabel() {

			AddressLabel = new Label();
			AddressLabel.Text = "  Enter address below:";
			AddressLabel.FontSize = 20;
			AddressLabel.TextColor = Color.Blue;
			CurrentStackLayout.Children.Add (AddressLabel);	
		}

		private void CreateAddressEditor() {

			AddressEditor = new Editor();
			AddressEditor.BackgroundColor = Color.Gray;
			CurrentStackLayout.Children.Add (AddressEditor);	

		}

		private void CreateClearButton() {

			ClearButton = new Button();
			ClearButton.BackgroundColor = Color.Lime;
			ClearButton.Text = "Clear";
			ClearButton.Clicked += (object sender, EventArgs e) => ClearTapped(sender, e);
			CurrentStackLayout.Children.Add (ClearButton);


		}

		private void CreateSaveButton() {

			SaveButton = new Button();
			SaveButton.BackgroundColor = Color.Lime;
			SaveButton.Text = "Save";
			SaveButton.Clicked += (object sender, EventArgs e) => SaveTapped(sender, e);
			CurrentStackLayout.Children.Add (SaveButton);

		}

		private void CreateChildSuccessPage() {
			
			CurrentStackLayout.Children.Add(SuccessPage.Content);

		}

		public void ClearTapped (object sender, EventArgs e){

			FirstNameEntry.Text = "";
			LastNameEntry.Text = "";
			ExperienceEntry.Text = "";
			AddressEditor.Text = "";
			this.Navigation.PopAsync();

//			SuccessPage.Content.IsVisible = false;

		}

		public void SaveTapped (object sender, EventArgs e){

//			FirstNameEntry.Text = "";

//			this.Navigation.PushAsync(new RegisterViewController());

//			SuccessPage.Content.IsVisible = true;


		}
			
	}




}


