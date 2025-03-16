namespace KalkulatorRachunku
{
    public partial class MainPage : ContentPage
    {
        float billAmount = 0;
        int guests = 1;
        int tipPercent = 15;
        public MainPage()
        {
            InitializeComponent();
            DisplayTotalBillAmount();
        }

        private void BillAmountChanged(object sender, EventArgs e)
        {
            if(billAmountEntry.Text != "")
            {
                billAmount = float.Parse(billAmountEntry.Text);
            } else { billAmount = 0; }

            DisplayTotalBillAmount();
        }

        private void GuestsChanged(object sender, EventArgs e)
        {
            guests = int.Parse(GuestsEntry.Text);
            DisplayTotalBillAmount();
        }

        private void TipSliderChanged(object sender, EventArgs e)
        {
            tipPercent = (int)TipSlider.Value;
            TipLabel.Text = tipPercent.ToString() + "%";
            DisplayTotalBillAmount();
        }

        private void DisplayTotalBillAmount()
        {
            float totalBillAmount = billAmount + (billAmount * tipPercent / 100);
            BillTotalAmountLabel.Text = "Do zapłaty: " + totalBillAmount.ToString() + "zł";
            DisplayPersonalBillAmount();
        }

        private void DisplayPersonalBillAmount()
        {
            float totalBillAmount = billAmount + (billAmount * tipPercent / 100);
            float personalBillAmount = totalBillAmount / guests;
            BillPersonalAmountLabel.Text = "Na osobę: " + personalBillAmount.ToString() + "zł";
        }

        private void TipButton10Clicked(object sender, EventArgs e)
        {
            TipSlider.Value = 10;
        }

        private void TipButton15Clicked(object sender, EventArgs e)
        {
            TipSlider.Value = 15;
        }
        private void TipButton20Clicked(object sender, EventArgs e)
        {
            TipSlider.Value = 20;
        }
    }

}
