namespace NetCoreFundamentos
{
    partial class Form05Char
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtLetras = new TextBox();
            txtNumeros = new TextBox();
            txtSimbolos = new TextBox();
            txtPuntuacion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnASCII = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "Letras";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(23, 60);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(124, 67);
            txtLetras.TabIndex = 1;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(272, 60);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(129, 67);
            txtNumeros.TabIndex = 2;
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(23, 253);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(124, 78);
            txtSimbolos.TabIndex = 3;
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(272, 264);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(130, 67);
            txtPuntuacion.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(272, 21);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 5;
            label2.Text = "Numeros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(34, 225);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 6;
            label3.Text = "Simbolos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(272, 225);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 7;
            label4.Text = "Puntuacion";
            // 
            // btnASCII
            // 
            btnASCII.Location = new Point(141, 379);
            btnASCII.Name = "btnASCII";
            btnASCII.Size = new Size(134, 34);
            btnASCII.TabIndex = 8;
            btnASCII.Text = "Run ASCII";
            btnASCII.UseVisualStyleBackColor = true;
            btnASCII.Click += btnASCII_Click;
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 451);
            Controls.Add(btnASCII);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPuntuacion);
            Controls.Add(txtSimbolos);
            Controls.Add(txtNumeros);
            Controls.Add(txtLetras);
            Controls.Add(label1);
            Name = "Form05Char";
            Text = "Form05Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLetras;
        private TextBox txtNumeros;
        private TextBox txtSimbolos;
        private TextBox txtPuntuacion;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnASCII;
    }
}