﻿namespace BasicAnimation
{
	public class RotateAnimationPageCode : ContentPage
	{
		Image image;
		Button startButton, cancelButton;

		public RotateAnimationPageCode ()
		{
			Title = "Rotate Animation";

			image = new Image { Source = ImageSource.FromFile ("dotnet_bot.png"), VerticalOptions = LayoutOptions.Center };
			startButton = new Button { Text = "Start Animation", VerticalOptions = LayoutOptions.End };
			cancelButton = new Button { Text = "Cancel Animation", IsEnabled = false };

			startButton.Clicked += OnStartAnimationButtonClicked;
			cancelButton.Clicked += OnCancelAnimationButtonClicked;

			Content = new StackLayout { 
				Margin = new Thickness (0, 20, 0, 0),
				Children = {
					image,
					startButton,
					cancelButton
				}
			};
		}

		void SetIsEnabledButtonState (bool startButtonState, bool cancelButtonState)
		{
			startButton.IsEnabled = startButtonState;
			cancelButton.IsEnabled = cancelButtonState;
		}

		async void OnStartAnimationButtonClicked (object sender, EventArgs e)
		{
			SetIsEnabledButtonState (false, true);

			await image.RotateTo (360, 2000);
			image.Rotation = 0;

			SetIsEnabledButtonState (true, false);
		}

		void OnCancelAnimationButtonClicked (object sender, EventArgs e)
		{
			image.CancelAnimations();
			SetIsEnabledButtonState(true, false);
		}
	}
}
