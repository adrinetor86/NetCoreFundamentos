namespace NetCoreFundamentos
{
    partial class Form24ColeccionMascotasXML
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
            btnLeer = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            label2 = new Label();
            txtEdad = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnGuardar = new Button();
            lstMascotas = new ListBox();
            btnNueva = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            btnExaminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(440, 134);
            btnLeer.Margin = new Padding(4);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(146, 42);
            btnLeer.TabIndex = 0;
            btnLeer.Text = "Leer Mascotas";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 62);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(61, 96);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(127, 29);
            txtNombre.TabIndex = 2;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(61, 189);
            txtRaza.Margin = new Padding(4);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(127, 29);
            txtRaza.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 155);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 3;
            label2.Text = "Raza";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(61, 277);
            txtEdad.Margin = new Padding(4);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(127, 29);
            txtEdad.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 243);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 5;
            label3.Text = "Edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 75);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 7;
            label4.Text = "Mascotas";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(440, 218);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(146, 46);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar Mascotas";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(260, 117);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(152, 193);
            lstMascotas.TabIndex = 9;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(52, 332);
            btnNueva.Margin = new Padding(4);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(146, 42);
            btnNueva.TabIndex = 10;
            btnNueva.Text = "Nueva Mascota";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(623, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 278);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(440, 328);
            btnExaminar.Margin = new Padding(4);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(146, 46);
            btnExaminar.TabIndex = 12;
            btnExaminar.Text = "Examinar...";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // Form24ColeccionMascotasXML
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 500);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
            Controls.Add(btnNueva);
            Controls.Add(lstMascotas);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnLeer);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form24ColeccionMascotasXML";
            Text = "Form24ColeccionMascotasXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeer;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtEdad;
        private Label label3;
        private Label label4;
        private Button btnGuardar;
        private ListBox lstMascotas;
        private Button btnNueva;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button btnExaminar;
    }
}