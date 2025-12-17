namespace NetCoreFundamentos
{
    partial class Form12ColeccionNumeros
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
            lstNumeros = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSuma = new TextBox();
            txtPares = new TextBox();
            txtImpares = new TextBox();
            btnGenerar = new Button();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 19);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 12;
            label1.Text = "Numeros";
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(47, 58);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(129, 169);
            lstNumeros.TabIndex = 11;
            lstNumeros.SelectedIndexChanged += lstNumeros_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 117);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 13;
            label2.Text = "Suma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 160);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 14;
            label3.Text = "Pares";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(204, 209);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 15;
            label4.Text = "Impares";
            label4.Click += label4_Click;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(259, 117);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 16;
            // 
            // txtPares
            // 
            txtPares.Location = new Point(259, 160);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(100, 23);
            txtPares.TabIndex = 17;
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(259, 201);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(100, 23);
            txtImpares.TabIndex = 18;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(221, 33);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(115, 31);
            btnGenerar.TabIndex = 19;
            btnGenerar.Text = "Generar Numeros";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(221, 70);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(115, 29);
            btnMostrar.TabIndex = 20;
            btnMostrar.Text = "Mostrar Datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form12ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 350);
            Controls.Add(btnMostrar);
            Controls.Add(btnGenerar);
            Controls.Add(txtImpares);
            Controls.Add(txtPares);
            Controls.Add(txtSuma);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstNumeros);
            Name = "Form12ColeccionNumeros";
            Text = "Form12ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNumeros;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSuma;
        private TextBox txtPares;
        private TextBox txtImpares;
        private Button btnGenerar;
        private Button btnMostrar;
    }
}