﻿namespace BasicAnimation
{
	public class TransformAnimationPageCode : ContentPage
	{
		Image image;
		Button startButton, cancelButton;

		public TransformAnimationPageCode ()
		{
			Title = "Transform Animation";

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

			bool isCancelled = await image.TranslateTo (-100, 0, 1000);
			if (!isCancelled) {				
				isCancelled = await image.TranslateTo (-100, -100, 1000);
			}
			if (!isCancelled) {		
				isCancelled = await image.TranslateTo (100, 100, 2000);
			}
			if (!isCancelled) {		
				isCancelled = await image.TranslateTo (0, 100, 1000);
			}
			if (!isCancelled) {		
				isCancelled = await image.TranslateTo (0, 0, 1000);
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


