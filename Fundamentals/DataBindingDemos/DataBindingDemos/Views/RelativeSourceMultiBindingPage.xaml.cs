namespace DataBindingDemos
{
    public partial class RelativeSourceMultiBindingPage : ContentPage
    {
        public RelativeSourceMultiBindingPage()
        {
            InitializeComponent();
        }

        void OnTapGestureRecognized(object sender, EventArgs e)
        {
            ExpanderGrid expanderGrid = sender as ExpanderGrid;
            expanderGrid.IsExpanded = !expanderGrid.IsExpanded;
        }
    }
}
