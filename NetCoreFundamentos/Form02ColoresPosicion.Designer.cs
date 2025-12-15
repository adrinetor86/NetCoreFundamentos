namespace NetCoreFundamentos
{
    partial class Form02ColoresPosicion
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
            btnPosicion = new Button();
            label2 = new Label();
            txtPosicionY = new TextBox();
            txtPosicionX = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAzul = new TextBox();
            txtVerde = new TextBox();
            txtRojo = new TextBox();
            btnFondo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 45);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "Posición X";
            // 
            // btnPosicion
            // 
            btnPosicion.ForeColor = SystemColors.ControlText;
            btnPosicion.Location = new Point(23, 249);
            btnPosicion.Margin = new Padding(5);
            btnPosicion.Name = "btnPosicion";
            btnPosicion.Size = new Size(163, 72);
            btnPosicion.TabIndex = 1;
            btnPosicion.Text = "Cambiar Posición";
            btnPosicion.UseVisualStyleBackColor = true;
            btnPosicion.Click += btnPosicion_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 144);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 2;
            label2.Text = "Posición Y";
            // 
            // txtPosicionY
            // 
            txtPosicionY.Location = new Point(23, 174);
            txtPosicionY.Margin = new Padding(5);
            txtPosicionY.Name = "txtPosicionY";
            txtPosicionY.Size = new Size(155, 33);
            txtPosicionY.TabIndex = 4;
            // 
            // txtPosicionX
            // 
            txtPosicionX.Location = new Point(23, 86);
            txtPosicionX.Margin = new Padding(5);
            txtPosicionX.Name = "txtPosicionX";
            txtPosicionX.Size = new Size(155, 33);
            txtPosicionX.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(582, 86);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 6;
            label3.Text = "Rojo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(582, 161);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 7;
            label4.Text = "Verde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(582, 235);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 8;
            label5.Text = "Azul";
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(678, 235);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 33);
            txtAzul.TabIndex = 9;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(678, 161);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 33);
            txtVerde.TabIndex = 10;
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(678, 86);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 33);
            txtRojo.TabIndex = 11;
            // 
            // btnFondo
            // 
            btnFondo.Location = new Point(648, 313);
            btnFondo.Name = "btnFondo";
            btnFondo.Size = new Size(170, 70);
            btnFondo.TabIndex = 12;
            btnFondo.Text = "Cambiar Fondo";
            btnFondo.UseVisualStyleBackColor = true;
            btnFondo.Click += btnFondo_Click;
            // 
            // Form02ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1257, 750);
            Controls.Add(btnFondo);
            Controls.Add(txtRojo);
            Controls.Add(txtVerde);
            Controls.Add(txtAzul);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPosicionX);
            Controls.Add(txtPosicionY);
            Controls.Add(label2);
            Controls.Add(btnPosicion);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form02ColoresPosicion";
            Text = "Form02ColoresPosicion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPosicion;
        private Label label2;
        private TextBox txtPosicionY;
        private TextBox txtPosicionX;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAzul;
        private TextBox txtVerde;
        private TextBox txtRojo;
        private Button btnFondo;
    }
}