using System.Reflection;

namespace WebViewDemos
{
    public partial class EvaluateJavaScriptPage : ContentPage
    {
        public EvaluateJavaScriptPage()
        {
            InitializeComponent();

            webView.Source = LoadHTMLFileFromResource();
        }

        HtmlWebViewSource LoadHTMLFileFromResource()
        {
            var source = new HtmlWebViewSource();

            // Load the HTML file embedded as a resource in the .NET Standard library
            var assembly = typeof(EvaluateJavaScriptPage).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream("WebViewDemos.index.html");            
            using (var reader = new StreamReader(stream))
            {
                source.Html = reader.ReadToEnd();
            }
            return source;
        }

        async void OnCallJavaScriptButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numberEntry.Text))
            {
                return;
            }

            int number = int.Parse(numberEntry.Text);
            string result = await webView.EvaluateJavaScriptAsync($"factorial({number})");
            resultLabel.Text = $"Factorial of {number} is {result}.";
        }
    }
}
