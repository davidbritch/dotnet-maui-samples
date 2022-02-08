namespace AnimationDemo
{
	public partial class ColorAnimationPage : ContentPage
	{
		public ColorAnimationPage()
		{
			InitializeComponent();
		}

		void SetIsEnabledCancelButtonState(bool cancelButtonState)
		{
			cancelButton.IsEnabled = cancelButtonState;
		}

		async void OnAnimateLabelButtonClicked(object sender, EventArgs e)
		{
			SetIsEnabledCancelButtonState(true);

			await Task.WhenAll(
				label.ColorTo(Colors.Red, Colors.Blue, c => label.TextColor = c, 5000),
				label.ColorTo(Colors.Blue, Colors.Red, c => label.BackgroundColor = c, 5000));

			label.BackgroundColor = Colors.White;
			label.TextColor = Colors.Black;
		}

		async void OnAnimatePageBackgroundButtonClicked(object sender, EventArgs e)
		{
			SetIsEnabledCancelButtonState(true);
			await this.ColorTo(Color.FromRgb(0, 0, 0), Color.FromRgb(255, 255, 255), c => BackgroundColor = c, 5000);
			BackgroundColor = Colors.White;
		}

		async void OnAnimateBoxViewButtonClicked(object sender, EventArgs e)
		{
			SetIsEnabledCancelButtonState(true);
			await boxView.ColorTo(Colors.Blue, Colors.Red, c => boxView.Color = c, 4000);
		}

		void OnCancelAnimationButtonClicked(object sender, EventArgs e)
		{
			boxView.CancelAnimation();
			label.CancelAnimation();
			this.CancelAnimation();
			SetIsEnabledCancelButtonState(false);
		}
	}
}
