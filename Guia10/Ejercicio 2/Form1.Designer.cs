namespace Ejercicio_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbNombre = new TextBox();
            btnImprimirNombre = new Button();
            tbInvitaciones = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del invitado";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(134, 36);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 1;
            // 
            // btnImprimirNombre
            // 
            btnImprimirNombre.Location = new Point(294, 7);
            btnImprimirNombre.Name = "btnImprimirNombre";
            btnImprimirNombre.Size = new Size(166, 52);
            btnImprimirNombre.TabIndex = 2;
            btnImprimirNombre.Text = "Imprimir Numero";
            btnImprimirNombre.UseVisualStyleBackColor = true;
            btnImprimirNombre.Click += btnImprimirNombre_Click;
            // 
            // tbInvitaciones
            // 
            tbInvitaciones.Location = new Point(12, 65);
            tbInvitaciones.Multiline = true;
            tbInvitaciones.Name = "tbInvitaciones";
            tbInvitaciones.Size = new Size(448, 218);
            tbInvitaciones.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbInvitaciones);
            Controls.Add(btnImprimirNombre);
            Controls.Add(tbNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNombre;
        private Button btnImprimirNombre;
        private TextBox tbInvitaciones;
    }
}
