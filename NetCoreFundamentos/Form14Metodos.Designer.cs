namespace NetCoreFundamentos
{
    partial class Form14Metodos
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
            txtNumero = new TextBox();
            btnDoble = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblRaton = new Label();
            txtSoloNum = new TextBox();
            txtLetras = new TextBox();
            btnReferencia = new Button();
            btnObjetoRef = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 83);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(54, 135);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnDoble
            // 
            btnDoble.Location = new Point(54, 254);
            btnDoble.Name = "btnDoble";
            btnDoble.Size = new Size(75, 23);
            btnDoble.TabIndex = 2;
            btnDoble.Text = "Doble Valor";
            btnDoble.UseVisualStyleBackColor = true;
            btnDoble.Click += btnDoble_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(320, 80);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 3;
            label2.Text = "Solo Numeros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 156);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 4;
            label3.Text = "Solo Letras";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 216);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // lblRaton
            // 
            lblRaton.BackColor = SystemColors.ActiveCaption;
            lblRaton.Location = new Point(376, 258);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(169, 94);
            lblRaton.TabIndex = 6;
            lblRaton.Text = "label5";
            lblRaton.Click += lblRaton_Click;
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // txtSoloNum
            // 
            txtSoloNum.Location = new Point(376, 80);
            txtSoloNum.Name = "txtSoloNum";
            txtSoloNum.Size = new Size(100, 23);
            txtSoloNum.TabIndex = 7;
            txtSoloNum.KeyPress += txtSoloNum_KeyPress;
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(376, 153);
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(100, 23);
            txtLetras.TabIndex = 8;
            txtLetras.KeyPress += txtLetras_KeyPress;
            // 
            // btnReferencia
            // 
            btnReferencia.Location = new Point(54, 308);
            btnReferencia.Name = "btnReferencia";
            btnReferencia.Size = new Size(120, 23);
            btnReferencia.TabIndex = 9;
            btnReferencia.Text = "Doble Referencia";
            btnReferencia.UseVisualStyleBackColor = true;
            btnReferencia.Click += btnReferencia_Click;
            // 
            // btnObjetoRef
            // 
            btnObjetoRef.Location = new Point(54, 364);
            btnObjetoRef.Name = "btnObjetoRef";
            btnObjetoRef.Size = new Size(120, 42);
            btnObjetoRef.TabIndex = 10;
            btnObjetoRef.Text = "Objeto Referencia";
            btnObjetoRef.UseVisualStyleBackColor = true;
            btnObjetoRef.Click += btnObjetoRef_Click;
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnObjetoRef);
            Controls.Add(btnReferencia);
            Controls.Add(txtLetras);
            Controls.Add(txtSoloNum);
            Controls.Add(lblRaton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDoble);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnDoble;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblRaton;
        private TextBox txtSoloNum;
        private TextBox txtLetras;
        private Button btnReferencia;
        private Button btnObjetoRef;
    }
}