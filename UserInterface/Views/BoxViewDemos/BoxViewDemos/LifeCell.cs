namespace BoxViewDemos
{
    class LifeCell : BoxView
    {
        bool isAlive;

        public event EventHandler Tapped;

        public LifeCell()
        {
            BackgroundColor = Colors.White;

            TapGestureRecognizer tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += (sender, args) =>
            {
                Tapped?.Invoke(this, EventArgs.Empty);
            };
            GestureRecognizers.Add(tapGesture);
        }

        public int Col { set; get; }

        public int Row { set; get; }

        public bool IsAlive
        {
            set
            {
                if (isAlive != value)
                {
                    isAlive = value;
                    BackgroundColor = isAlive ? Colors.Black : Colors.White;
                }
            }
            get
            {
                return isAlive;
            }
        }
    }
}
