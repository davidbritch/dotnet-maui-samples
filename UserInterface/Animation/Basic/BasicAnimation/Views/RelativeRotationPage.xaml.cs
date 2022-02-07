namespace BasicAnimation
{
	public partial class RelativeRotationPage : ContentPage
	{
		public RelativeRotationPage ()
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
			await image.RelRotateTo (360, 2000);
			SetIsEnabledButtonState (true, false);
		}

		void OnCancelAnimationButtonClicked (object sender, EventArgs e)
		{
			image.CancelAnimations();
			SetIsEnabledButtonState (true, false);
		}
	}
}

