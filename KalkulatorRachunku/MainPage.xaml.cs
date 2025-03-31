namespace KalkulatorRachunku
{
    public partial class MainPage : ContentPage
    {
        int billAmountInt = 0;
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
                float billAmount = float.Parse(billAmountEntry.Text);
                float bAD = float.Round(billAmount, 2);
                billAmountInt = (int)bAD * 100;
            } else { billAmountInt = 0; }

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
            float totalBillAmount = billAmountInt + (billAmountInt * tipPercent / 100);
            float totalBillAmountZloty = totalBillAmount / 100;
            BillTotalAmountLabel.Text = "Do zapłaty: " + float.Round(totalBillAmountZloty, 2).ToString() + "zł";
            DisplayPersonalBillAmount();
        }

        private void DisplayPersonalBillAmount()
        {
            float totalBillAmount = billAmountInt + (billAmountInt * tipPercent / 100);
            float personalBillAmount = (totalBillAmount / guests) / 100;
            BillPersonalAmountLabel.Text = "Na osobę: " + float.Round(personalBillAmount, 2).ToString() + "zł";
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
