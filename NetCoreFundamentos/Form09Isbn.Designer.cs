namespace NetCoreFundamentos
{
    partial class Form09Isbn
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
            lblisbn = new Label();
            btnIsbn = new Button();
            txtIsbn = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 39);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduzca ISBN";
            // 
            // lblisbn
            // 
            lblisbn.AutoSize = true;
            lblisbn.Location = new Point(36, 194);
            lblisbn.Name = "lblisbn";
            lblisbn.Size = new Size(32, 15);
            lblisbn.TabIndex = 1;
            lblisbn.Text = "ISBN";
            // 
            // btnIsbn
            // 
            btnIsbn.Location = new Point(52, 119);
            btnIsbn.Name = "btnIsbn";
            btnIsbn.Size = new Size(75, 23);
            btnIsbn.TabIndex = 2;
            btnIsbn.Text = "Validar ISBN";
            btnIsbn.UseVisualStyleBackColor = true;
            btnIsbn.Click += btnIsbn_Click;
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(36, 78);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(100, 23);
            txtIsbn.TabIndex = 3;
            // 
            // Form09Isbn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 390);
            Controls.Add(txtIsbn);
            Controls.Add(btnIsbn);
            Controls.Add(lblisbn);
            Controls.Add(label1);
            Name = "Form09Isbn";
            Text = "Form09Isbn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblisbn;
        private Button btnIsbn;
        private TextBox txtIsbn;
    }
}