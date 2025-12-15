namespace NetCoreFundamentos
{
    partial class Form01SumarNumeros
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
            btnNumeros = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNumero2 = new TextBox();
            txtNumero1 = new TextBox();
            txtResultado = new Label();
            SuspendLayout();
            // 
            // btnNumeros
            // 
            btnNumeros.Location = new Point(203, 103);
            btnNumeros.Name = "btnNumeros";
            btnNumeros.Size = new Size(204, 46);
            btnNumeros.TabIndex = 0;
            btnNumeros.Text = "Sumar Numeros";
            btnNumeros.UseVisualStyleBackColor = true;
            btnNumeros.Click += btnNumeros_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 30);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Numero 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 112);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Numero 2";
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(40, 150);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 3;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(40, 60);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 4;
            // 
            // txtResultado
            // 
            txtResultado.AutoSize = true;
            txtResultado.Location = new Point(40, 215);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(38, 15);
            txtResultado.TabIndex = 5;
            txtResultado.Text = "label3";
            txtResultado.Click += label3_Click;
            // 
            // Form01SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 285);
            Controls.Add(txtResultado);
            Controls.Add(txtNumero1);
            Controls.Add(txtNumero2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNumeros);
            Name = "Form01SumarNumeros";
            Text = "Form01SumarNumeros";
            Load += Form01SumarNumeros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNumeros;
        private Label label1;
        private Label label2;
        private TextBox txtNumero2;
        private TextBox txtNumero1;
        private Label txtResultado;
    }
}