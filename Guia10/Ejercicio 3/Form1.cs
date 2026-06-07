namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnImprimirNombre_Click(object sender, EventArgs e)
        {
            IsbInvitaciones.Items.Add(tbNombre.Text);
            tbNombre.Clear();
        }
    }
}