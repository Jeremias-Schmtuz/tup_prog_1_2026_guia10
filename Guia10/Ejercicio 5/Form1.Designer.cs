namespace Ejercicio_5
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
            rbExcelente = new RadioButton();
            rbBueno = new RadioButton();
            rbInsuficiente = new RadioButton();
            btnVotar = new Button();
            label1 = new Label();
            label2 = new Label();
            lbTotal = new Label();
            lbExcelente = new Label();
            lbBueno = new Label();
            lbInsuficiente = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // rbExcelente
            // 
            rbExcelente.AutoSize = true;
            rbExcelente.Location = new Point(50, 44);
            rbExcelente.Name = "rbExcelente";
            rbExcelente.Size = new Size(75, 19);
            rbExcelente.TabIndex = 0;
            rbExcelente.Text = "Excelente";
            rbExcelente.UseVisualStyleBackColor = true;
            // 
            // rbBueno
            // 
            rbBueno.AutoSize = true;
            rbBueno.Location = new Point(50, 82);
            rbBueno.Name = "rbBueno";
            rbBueno.Size = new Size(59, 19);
            rbBueno.TabIndex = 1;
            rbBueno.Text = "Bueno";
            rbBueno.UseVisualStyleBackColor = true;
            // 
            // rbInsuficiente
            // 
            rbInsuficiente.AutoSize = true;
            rbInsuficiente.Location = new Point(50, 123);
            rbInsuficiente.Name = "rbInsuficiente";
            rbInsuficiente.Size = new Size(86, 19);
            rbInsuficiente.TabIndex = 2;
            rbInsuficiente.Text = "Insuficiente";
            rbInsuficiente.UseVisualStyleBackColor = true;
            // 
            // btnVotar
            // 
            btnVotar.Location = new Point(232, 71);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(130, 41);
            btnVotar.TabIndex = 3;
            btnVotar.Text = "Votar";
            btnVotar.UseVisualStyleBackColor = true;
            btnVotar.Click += btnVotar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 227);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 5;
            label2.Text = "Cantidad de votaciones:";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(232, 227);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(0, 15);
            lbTotal.TabIndex = 6;
            // 
            // lbExcelente
            // 
            lbExcelente.AutoSize = true;
            lbExcelente.Location = new Point(232, 270);
            lbExcelente.Name = "lbExcelente";
            lbExcelente.Size = new Size(0, 15);
            lbExcelente.TabIndex = 7;
            // 
            // lbBueno
            // 
            lbBueno.AutoSize = true;
            lbBueno.Location = new Point(232, 312);
            lbBueno.Name = "lbBueno";
            lbBueno.Size = new Size(0, 15);
            lbBueno.TabIndex = 8;
            // 
            // lbInsuficiente
            // 
            lbInsuficiente.AutoSize = true;
            lbInsuficiente.Location = new Point(232, 356);
            lbInsuficiente.Name = "lbInsuficiente";
            lbInsuficiente.Size = new Size(0, 15);
            lbInsuficiente.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 270);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 10;
            label3.Text = "Excelentes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 312);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 11;
            label4.Text = "Buenos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(133, 356);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 12;
            label5.Text = "Insuficientes:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbInsuficiente);
            Controls.Add(lbBueno);
            Controls.Add(lbExcelente);
            Controls.Add(lbTotal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVotar);
            Controls.Add(rbInsuficiente);
            Controls.Add(rbBueno);
            Controls.Add(rbExcelente);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbExcelente;
        private RadioButton rbBueno;
        private RadioButton rbInsuficiente;
        private Button btnVotar;
        private Label label1;
        private Label label2;
        private Label lbTotal;
        private Label lbExcelente;
        private Label lbBueno;
        private Label lbInsuficiente;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
