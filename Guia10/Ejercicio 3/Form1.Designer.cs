namespace Ejercicio_3
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
            btnImprimirNombre = new Button();
            tbNombre = new TextBox();
            label2 = new Label();
            IsbInvitaciones = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 37);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // btnImprimirNombre
            // 
            btnImprimirNombre.Location = new Point(294, 6);
            btnImprimirNombre.Name = "btnImprimirNombre";
            btnImprimirNombre.Size = new Size(166, 52);
            btnImprimirNombre.TabIndex = 5;
            btnImprimirNombre.Text = "Imprimir Nombre";
            btnImprimirNombre.UseVisualStyleBackColor = true;
            btnImprimirNombre.Click += btnImprimirNombre_Click;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(134, 34);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre del invitado";
            // 
            // IsbInvitaciones
            // 
            IsbInvitaciones.FormattingEnabled = true;
            IsbInvitaciones.Location = new Point(12, 64);
            IsbInvitaciones.Name = "IsbInvitaciones";
            IsbInvitaciones.Size = new Size(448, 214);
            IsbInvitaciones.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IsbInvitaciones);
            Controls.Add(label2);
            Controls.Add(tbNombre);
            Controls.Add(btnImprimirNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnImprimirNombre;
        private TextBox tbNombre;
        private Label label2;
        private ListBox IsbInvitaciones;
    }
}
