namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimirNombre_Click(object sender, EventArgs e)
        {
            tbInvitaciones.Text += tbNombre.Text + "\r\n";
            tbNombre.Clear();
        }
    }
}