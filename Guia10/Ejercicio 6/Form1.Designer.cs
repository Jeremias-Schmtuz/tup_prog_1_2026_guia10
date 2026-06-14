namespace Ejercicio_6
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
            chbOpcion1 = new CheckBox();
            chbOpcion2 = new CheckBox();
            chbOpcion3 = new CheckBox();
            label2 = new Label();
            lbResultado = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Una varibales local:";
            // 
            // chbOpcion1
            // 
            chbOpcion1.AutoSize = true;
            chbOpcion1.Location = new Point(12, 47);
            chbOpcion1.Name = "chbOpcion1";
            chbOpcion1.Size = new Size(193, 19);
            chbOpcion1.TabIndex = 1;
            chbOpcion1.Text = "No siempre se debe inicializarse";
            chbOpcion1.UseVisualStyleBackColor = true;
            // 
            // chbOpcion2
            // 
            chbOpcion2.AutoSize = true;
            chbOpcion2.Location = new Point(12, 72);
            chbOpcion2.Name = "chbOpcion2";
            chbOpcion2.Size = new Size(153, 19);
            chbOpcion2.TabIndex = 2;
            chbOpcion2.Text = "Nunca debe inicializarse";
            chbOpcion2.UseVisualStyleBackColor = true;
            // 
            // chbOpcion3
            // 
            chbOpcion3.AutoSize = true;
            chbOpcion3.Location = new Point(12, 97);
            chbOpcion3.Name = "chbOpcion3";
            chbOpcion3.Size = new Size(161, 19);
            chbOpcion3.TabIndex = 3;
            chbOpcion3.Text = "Siempre debe inicializarse";
            chbOpcion3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 165);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "Resultado:";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(98, 165);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(38, 15);
            lbResultado.TabIndex = 5;
            lbResultado.Text = "label3";
            // 
            // button1
            // 
            button1.Location = new Point(275, 50);
            button1.Name = "button1";
            button1.Size = new Size(160, 60);
            button1.TabIndex = 6;
            button1.Text = "btnResponder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 232);
            Controls.Add(button1);
            Controls.Add(lbResultado);
            Controls.Add(label2);
            Controls.Add(chbOpcion3);
            Controls.Add(chbOpcion2);
            Controls.Add(chbOpcion1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox chbOpcion1;
        private CheckBox chbOpcion2;
        private CheckBox chbOpcion3;
        private Label label2;
        private Label lbResultado;
        private Button button1;
    }
}
