namespace KalkulatorRachunku
{
    public partial class MainPage : ContentPage
    {
        int billAmount = 0;
        int guests = 1;
        public MainPage()
        {
            InitializeComponent();
        }

        private void BillAmountChanged(object sender, EventArgs e)
        {
            billAmount = int.Parse(billAmountEntry.Text);
        }

        private void GuestsChanged(object sender, EventArgs e)
        {
            guests = int.Parse(GuestsEntry.Text);
        }

        private void TipSliderChanged(object sender, EventArgs e)
        {

        }
    }

}
