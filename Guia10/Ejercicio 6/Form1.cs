namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool respuestaCorrecta = !chbOpcion1.Checked && !chbOpcion2.Checked && chbOpcion3.Checked;

            if (respuestaCorrecta)
            {
                lbResultado.Text = "Respuesta correcta";
            }
            else
            {
                string resultado = "Respuesta incorrecta:\n";

                if (chbOpcion1.Checked)
                {
                    resultado += "No siempre se debe inicializar. FALSO\n";
                }
                if (chbOpcion2.Checked)
                {
                    resultado += "Nunca debe incializarse. FALSO\n";
                }
                if (chbOpcion3.Checked)
                {
                    resultado += "Siempre debe incializarse. ¡VERDADERO!";
                }

                lbResultado.Text = resultado;
            }
        }
    }
}