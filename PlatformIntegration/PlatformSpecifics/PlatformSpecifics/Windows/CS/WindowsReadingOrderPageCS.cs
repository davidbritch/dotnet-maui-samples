﻿using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;

namespace PlatformSpecifics
{
    public class WindowsReadingOrderPageCS : ContentPage
    {
        Editor _editor;
        Microsoft.Maui.Controls.Label _label;

        public WindowsReadingOrderPageCS()
        {
			_editor = new Editor { HeightRequest = 80, Text = " שכל, ניווט ומהימנה תאולוגיה היא ב, זכר או מדעי תרומה מבוקשים. של ויש טכנולוגיה סוציולוגיה, מה אנא ביולי בקלות למחיקה. על חשמל אקטואליה רבה, שדרות ערכים ננקטת שמו בה. או עוד ציור מיזמים טבלאות, ריקוד קולנוע היסטוריה שכל ב", FlowDirection = FlowDirection.LeftToRight };
            _editor.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetDetectReadingOrderFromContent(true);
			_label = new Microsoft.Maui.Controls.Label();

			var toggleButton = new Button { Text = "Toggle detect from content" };
			toggleButton.Clicked += OnToggleButtonClicked;

			Title = "Text Reading Order";
            Content = new ScrollView
            {
				Margin = new Thickness(20),
                Content = new StackLayout 
				{
					Children = { _editor, _label, toggleButton }
                }
            };
            UpdateLabel();
		}

		void OnToggleButtonClicked(object sender, EventArgs e)
        {
            _editor.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().SetDetectReadingOrderFromContent(!_editor.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().GetDetectReadingOrderFromContent());
            UpdateLabel();
        }

        void UpdateLabel()
        {
            _label.Text = $"FlowDirection: {_editor.FlowDirection}, DetectReadingOrderFromContent: {_editor.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>().GetDetectReadingOrderFromContent()}";
        }
    }
}