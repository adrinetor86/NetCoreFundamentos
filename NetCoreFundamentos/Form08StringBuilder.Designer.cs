namespace NetCoreFundamentos
{
    partial class Form08StringBuilder
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
            txtTexto = new System.Windows.Forms.RichTextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnInvertir = new System.Windows.Forms.Button();
            btnInvertirBuilder = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtTexto
            // 
            txtTexto.Location = new System.Drawing.Point(75, 128);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new System.Drawing.Size(359, 137);
            txtTexto.TabIndex = 0;
            txtTexto.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(75, 83);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(137, 15);
            label1.TabIndex = 1;
            label1.Text = "Copie texto para trabajar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(75, 320);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Tiempo";
            // 
            // btnInvertir
            // 
            btnInvertir.Location = new System.Drawing.Point(75, 379);
            btnInvertir.Name = "btnInvertir";
            btnInvertir.Size = new System.Drawing.Size(154, 33);
            btnInvertir.TabIndex = 3;
            btnInvertir.Text = "Invertir String";
            btnInvertir.UseVisualStyleBackColor = true;
            btnInvertir.Click += btnInvertir_Click;
            // 
            // btnInvertirBuilder
            // 
            btnInvertirBuilder.Location = new System.Drawing.Point(286, 379);
            btnInvertirBuilder.Name = "btnInvertirBuilder";
            btnInvertirBuilder.Size = new System.Drawing.Size(148, 33);
            btnInvertirBuilder.TabIndex = 4;
            btnInvertirBuilder.Text = "Invertir String Builder";
            btnInvertirBuilder.UseVisualStyleBackColor = true;
            btnInvertirBuilder.Click += btnInvertirBuilder_Click;
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(534, 497);
            Controls.Add(btnInvertirBuilder);
            Controls.Add(btnInvertir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTexto);
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtTexto;
        private Label label1;
        private Label label2;
        private Button btnInvertir;
        private System.Windows.Forms.Button btnInvertirBuilder;
    }
}