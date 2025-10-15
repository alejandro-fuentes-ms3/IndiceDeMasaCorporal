using imc.Model;

namespace imc.Gui
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            Limpiarinformacion();
        }

        private void oncalcularbuttoncliked(object sender, EventArgs e)
        {
            decimal peso = Convert.ToDecimal(pesoEntry.Text);
            decimal estatura = Convert.ToDecimal(estaturaEntry.Text);
            decimal imc = peso / (estatura * estatura);
            imcLabel.Text = imc.ToString("F2");
            situacionnutricional.Text = IndiiceDeMasaCcorporallit.DeterminaEstadoNutericional(imc);
        }
        
        private void onlimpiarButton_Clicked(object sender, EventArgs e)
        {
            Limpiarinformacion();
        }
        private void Limpiarinformacion()
        {
            pesoEntry.Text = string.Empty;
            estaturaEntry.Text = string.Empty;
            imcLabel.Text = string.Empty;
            situacionnutricional.Text = string.Empty;
        }
        
    }
}
