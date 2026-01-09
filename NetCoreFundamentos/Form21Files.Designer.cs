namespace NetCoreFundamentos
{
    partial class Form21Files
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
            textBox1 = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lstNombres = new ListBox();
            btnNuevoNombre = new Button();
            btnLeer = new Button();
            btnWrite = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 24);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Contenido File";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 60);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 212);
            textBox1.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(302, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(141, 27);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 24);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(503, 24);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombres";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(503, 66);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(153, 204);
            lstNombres.TabIndex = 5;
            // 
            // btnNuevoNombre
            // 
            btnNuevoNombre.Location = new Point(302, 117);
            btnNuevoNombre.Name = "btnNuevoNombre";
            btnNuevoNombre.Size = new Size(141, 33);
            btnNuevoNombre.TabIndex = 6;
            btnNuevoNombre.Text = "Nuevo Nombre";
            btnNuevoNombre.UseVisualStyleBackColor = true;
            btnNuevoNombre.Click += btnNuevoNombre_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(302, 178);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(141, 30);
            btnLeer.TabIndex = 7;
            btnLeer.Text = "Leer file";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(302, 237);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(141, 35);
            btnWrite.TabIndex = 8;
            btnWrite.Text = "Write file";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 448);
            Controls.Add(btnWrite);
            Controls.Add(btnLeer);
            Controls.Add(btnNuevoNombre);
            Controls.Add(lstNombres);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private ListBox lstNombres;
        private Button btnNuevoNombre;
        private Button btnLeer;
        private Button btnWrite;
    }
}