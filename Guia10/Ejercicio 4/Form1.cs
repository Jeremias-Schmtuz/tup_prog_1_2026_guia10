namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int hora = Convert.ToInt32(nudHora.Value);
            int minutos = Convert.ToInt32(nudMinuto.Value);
            int Minutos = (hora * 60) + minutos;
            lbMinutos.Text = Minutos.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}