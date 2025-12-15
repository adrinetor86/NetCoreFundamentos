namespace NetCoreFundamentos
{
    partial class Form07SumarString
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
            label1 = new System.Windows.Forms.Label();
            txtSuma = new System.Windows.Forms.TextBox();
            btnSumar = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(79, 75);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // txtSuma
            // 
            txtSuma.Location = new System.Drawing.Point(79, 129);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new System.Drawing.Size(100, 23);
            txtSuma.TabIndex = 1;
            // 
            // btnSumar
            // 
            btnSumar.Location = new System.Drawing.Point(79, 181);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new System.Drawing.Size(75, 23);
            btnSumar.TabIndex = 2;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(79, 226);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Resultado";
            label2.Click += label2_Click;
            // 
            // Form07SumarString
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(308, 374);
            Controls.Add(label2);
            Controls.Add(btnSumar);
            Controls.Add(txtSuma);
            Controls.Add(label1);
            Text = "Form07SumarString";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSuma;
        private Button btnSumar;
        private System.Windows.Forms.Label label2;
    }
}