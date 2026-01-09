namespace NetCoreFundamentos
{
    partial class Form22MascotasFiles
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
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            btnNueva = new Button();
            btnLeer = new Button();
            btnEscribir = new Button();
            lstMascotas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 67);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 142);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 1;
            label2.Text = "Raza";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 67);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 2;
            label3.Text = "Mascotas";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(52, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(136, 29);
            txtNombre.TabIndex = 3;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(52, 166);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(136, 29);
            txtRaza.TabIndex = 4;
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(52, 228);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(136, 40);
            btnNueva.TabIndex = 5;
            btnNueva.Text = "Nueva Mascota";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(52, 274);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(136, 48);
            btnLeer.TabIndex = 6;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnEscribir
            // 
            btnEscribir.Location = new Point(52, 328);
            btnEscribir.Name = "btnEscribir";
            btnEscribir.Size = new Size(136, 45);
            btnEscribir.TabIndex = 7;
            btnEscribir.Text = "Escribir";
            btnEscribir.UseVisualStyleBackColor = true;
            btnEscribir.Click += btnEscribir_Click;
                // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(326, 114);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(188, 235);
            lstMascotas.TabIndex = 8;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // Form22MascotasFiles
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 417);
            Controls.Add(lstMascotas);
            Controls.Add(btnEscribir);
            Controls.Add(btnLeer);
            Controls.Add(btnNueva);
            Controls.Add(txtRaza);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form22MascotasFiles";
            Text = "Form22MascotasFiles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private Button btnNueva;
        private Button btnLeer;
        private Button btnEscribir;
        private ListBox lstMascotas;
    }
}