namespace Ejercicio_4
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
            label2 = new Label();
            nudHora = new NumericUpDown();
            nudMinuto = new NumericUpDown();
            label3 = new Label();
            btnConvertir = new Button();
            lbMinutos = new Label();
            ((System.ComponentModel.ISupportInitialize)nudHora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinuto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Tiempo en H:M";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Tiempo en Minutos";
            // 
            // nudHora
            // 
            nudHora.Location = new Point(126, 7);
            nudHora.Name = "nudHora";
            nudHora.Size = new Size(45, 23);
            nudHora.TabIndex = 2;
            // 
            // nudMinuto
            // 
            nudMinuto.Location = new Point(217, 7);
            nudMinuto.Name = "nudMinuto";
            nudMinuto.Size = new Size(45, 23);
            nudMinuto.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 9);
            label3.Name = "label3";
            label3.Size = new Size(10, 15);
            label3.TabIndex = 4;
            label3.Text = ":";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(312, 7);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(140, 54);
            btnConvertir.TabIndex = 5;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lbMinutos
            // 
            lbMinutos.AutoSize = true;
            lbMinutos.Location = new Point(145, 109);
            lbMinutos.Name = "lbMinutos";
            lbMinutos.Size = new Size(0, 15);
            lbMinutos.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbMinutos);
            Controls.Add(btnConvertir);
            Controls.Add(label3);
            Controls.Add(nudMinuto);
            Controls.Add(nudHora);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudHora).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinuto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown nudHora;
        private NumericUpDown nudMinuto;
        private Label label3;
        private Button btnConvertir;
        private Label lbMinutos;
    }
}
