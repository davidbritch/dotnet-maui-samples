﻿namespace BasicAnimation
{
	public class ScaleAnimationPageCode : ContentPage
	{
		Image image;
		Button startButton, cancelButton;

		public ScaleAnimationPageCode ()
		{
			Title = "Scale Animation";

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

			bool isCancelled = await image.ScaleTo (2, 2000);
			if (!isCancelled) {
				await image.ScaleTo (1, 2000);
			}

			SetIsEnabledButtonState (true, false);
		}

		void OnCancelAnimationButtonClicked (object sender, EventArgs e)
		{
			image.CancelAnimations();
			SetIsEnabledButtonState(true, false);
		}
	}
}


