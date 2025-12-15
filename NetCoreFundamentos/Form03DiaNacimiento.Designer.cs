namespace NetCoreFundamentos
{
    partial class Form03DiaNacimiento
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
            btnMostarDia = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtDia = new System.Windows.Forms.TextBox();
            txtAño = new System.Windows.Forms.TextBox();
            txtMes = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnMostarDia
            // 
            btnMostarDia.Location = new System.Drawing.Point(108, 258);
            btnMostarDia.Name = "btnMostarDia";
            btnMostarDia.Size = new System.Drawing.Size(110, 33);
            btnMostarDia.TabIndex = 0;
            btnMostarDia.Text = "Mostrar Día";
            btnMostarDia.UseVisualStyleBackColor = true;
            btnMostarDia.Click += btnMostarDia_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(78, 100);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 15);
            label1.TabIndex = 1;
            label1.Text = "Día";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(79, 142);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(79, 199);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(29, 15);
            label3.TabIndex = 3;
            label3.Text = "Año";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(75, 308);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(162, 15);
            label4.TabIndex = 4;
            label4.Text = "El dia de nacimiento es Lunes";
            // 
            // txtDia
            // 
            txtDia.Location = new System.Drawing.Point(137, 97);
            txtDia.Name = "txtDia";
            txtDia.Size = new System.Drawing.Size(100, 23);
            txtDia.TabIndex = 5;
          
            // 
            // txtAño
            // 
            txtAño.Location = new System.Drawing.Point(137, 196);
            txtAño.Name = "txtAño";
            txtAño.Size = new System.Drawing.Size(100, 23);
            txtAño.TabIndex = 6;
            // 
            // txtMes
            // 
            txtMes.Location = new System.Drawing.Point(137, 142);
            txtMes.Name = "txtMes";
            txtMes.Size = new System.Drawing.Size(100, 23);
            txtMes.TabIndex = 7;
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(txtMes);
            Controls.Add(txtAño);
            Controls.Add(txtDia);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMostarDia);
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostarDia;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.TextBox txtDia;
        private TextBox txtAño;
        private TextBox txtMes;
    }
}