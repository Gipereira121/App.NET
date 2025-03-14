namespace AppCalcularDiasVividos
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }


        //criar um evento
        //private void btnNomeEventoOnClicked(object sender, EventArgs e) {}


        private void btnCalcularDiasOnClicked(object sender, EventArgs e)
        {
            int btnCalcularIdade = 0;

            btnCalcularIdade = int.Parse(etrIdade.Text) * 365;

            etrDiasVividos.Text = btnCalcularIdade.ToString();

            DisplayAlert("APP DIAS VIVIDOS", $"VocÊ já viveu (dias)")


        }




    }

}
