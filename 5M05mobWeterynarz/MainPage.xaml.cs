namespace _5M05mobWeterynarz
{
    //INF.04-01-24.06-SD
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            piZwierzak.SelectedItem = "Pies";
            entWlasciciel.Text = "";
            entCel.Text = "";
        }

        private void onSliderChanged(object sender, EventArgs e)
        {
            int wartosc = (int)sldWiek.Value;
            lblWiek.Text = $"Ile ma lat? {wartosc}";
        }

        private void onZwierzWyb(object sender, EventArgs e)
        {
            string zwierzak = piZwierzak.SelectedItem.ToString();
            if (zwierzak == "Pies")
                sldWiek.Maximum = 18;
            else if (zwierzak == "Kot")
                sldWiek.Maximum = 20;
            else if (zwierzak == "Świnka morska")
                sldWiek.Maximum = 9;

        }
        private void btnOKClicked(object sender, EventArgs e)
        {
            string s = "";
            s = entWlasciciel.Text + ", ";
            s += piZwierzak.SelectedItem.ToString() + ", ";
            s += ((int)sldWiek.Value).ToString() + ", ";
            s += entCel.Text + ", ";
            s += tpCzas.Time.ToString();
            lblWynik.Text = s;
        }


    }

}
