namespace BasicAnimation
{
	public partial class ScaleAnimationPage : ContentPage
	{
		public ScaleAnimationPage ()
		{
			InitializeComponent ();
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
