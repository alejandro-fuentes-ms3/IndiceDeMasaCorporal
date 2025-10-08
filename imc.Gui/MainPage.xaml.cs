namespace imc.Gui
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            pesoEntry.Text = string.Empty;
            estaturaEntry.Text = string.Empty;
            imcLabel.Text = string.Empty;
            situacionnutricional.Text = string.Empty;
        }

        private void oncalcularbuttoncliked(object sender, EventArgs e)
        {
            decimal peso = Convert.ToDecimal(pesoEntry.Text);
            decimal estatura = Convert.ToDecimal(estaturaEntry.Text);
            decimal imc = peso / (estatura * estatura);
            imcLabel.Text = imc.ToString("F2");
            situacionnutricional.Text = DeterminaEstadoNutericional(imc);
        }

        private void onlimpiarButton_Clicked(object sender, EventArgs e)
        {
            pesoEntry.Text = string.Empty;
            estaturaEntry.Text = string.Empty;
            imcLabel.Text = string.Empty;
            situacionnutricional.Text = string.Empty;
        }
        private decimal IndiceDeMasaCorporal(decimal peso,decimal estatura)
        { 
         return peso / (estatura * estatura);
        }
        private string DeterminaEstadoNutericional(decimal imc)
        {
            if (imc < 18.5m)
            {
                return "peso bajo";
            }
            if (imc < 25.00m) 
            {
                return "peso normal";
            }
            if (imc < 30m)
            {
                return "sobre peso";
            }
            if (imc < 40) 
            {
                return "Obesidad"; 
            }
               return "Obesidad extrema";
            
                


        }
    }
}
