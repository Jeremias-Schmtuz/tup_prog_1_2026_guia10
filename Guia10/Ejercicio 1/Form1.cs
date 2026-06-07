namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        Servicio servicio = new Servicio();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lbNumero.Text = servicio.GenerarNumeroRandom(). ToString();
        }
    }
}