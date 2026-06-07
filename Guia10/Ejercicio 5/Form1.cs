namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        int votosExcelentes;
        int votosBuenos;
        int votosInsuficientes;
        int cantidadVotaciones;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (rbExcelente.Checked)
            {
                votosExcelentes++;
                cantidadVotaciones++;
            }
            else if (rbBueno.Checked)
            {
                votosBuenos++;
                cantidadVotaciones++;
            }
            else if (rbInsuficiente.Checked)
            {
                votosInsuficientes++;
                cantidadVotaciones++;
            }

            lbExcelente.Text = votosExcelentes.ToString();
            lbBueno.Text = votosBuenos.ToString();
            lbInsuficiente.Text = votosInsuficientes.ToString();
            lbTotal.Text = cantidadVotaciones.ToString();
        }
    }
}