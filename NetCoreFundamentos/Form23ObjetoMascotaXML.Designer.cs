namespace NetCoreFundamentos
{
    partial class Form23ObjetoMascotaXML
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
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            txtEdad = new TextBox();
            label3 = new Label();
            btnLeer = new Button();
            btnGuardar = new Button();
            btnExaminar = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 113);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 206);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(136, 148);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(128, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(136, 239);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(128, 23);
            txtRaza.TabIndex = 3;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(136, 358);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 317);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Edad";
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(304, 126);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(152, 65);
            btnLeer.TabIndex = 6;
            btnLeer.Text = "Leer clase";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(304, 250);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(152, 62);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar clase";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(553, 345);
            btnExaminar.Margin = new Padding(4);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(146, 46);
            btnExaminar.TabIndex = 14;
            btnExaminar.Text = "Examinar...";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(532, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 278);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form23ObjetoMascotaXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 452);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeer);
            Controls.Add(label3);
            Controls.Add(txtEdad);
            Controls.Add(txtRaza);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form23ObjetoMascotaXML";
            Text = "Form23ObjetoMascotaXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private TextBox txtEdad;
        private Label label3;
        private Button btnLeer;
        private Button btnGuardar;
        private Button btnExaminar;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
    }
}