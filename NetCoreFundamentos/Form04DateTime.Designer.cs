namespace NetCoreFundamentos
{
    partial class Form04DateTime
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
            txtFecha = new TextBox();
            checkFormato = new CheckBox();
            label3 = new Label();
            rbdDias = new RadioButton();
            rbdMeses = new RadioButton();
            rbdAnio = new RadioButton();
            txtIncremento = new TextBox();
            btnIncrementar = new Button();
            label4 = new Label();
            txtFechaFinal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 84);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 0;
            label1.Text = "Fecha Actual";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 925);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 1;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(24, 158);
            txtFecha.Margin = new Padding(6, 8, 6, 8);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(669, 29);
            txtFecha.TabIndex = 2;
            // 
            // checkFormato
            // 
            checkFormato.AutoSize = true;
            checkFormato.Location = new Point(24, 300);
            checkFormato.Margin = new Padding(6, 8, 6, 8);
            checkFormato.Name = "checkFormato";
            checkFormato.Size = new Size(148, 25);
            checkFormato.TabIndex = 3;
            checkFormato.Text = "cambiar Formato";
            checkFormato.UseVisualStyleBackColor = true;
            checkFormato.CheckedChanged += checkFormato_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 658);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 4;
            label3.Text = "Incremento";
            // 
            // rbdDias
            // 
            rbdDias.AutoSize = true;
            rbdDias.Location = new Point(24, 420);
            rbdDias.Margin = new Padding(6, 8, 6, 8);
            rbdDias.Name = "rbdDias";
            rbdDias.Size = new Size(58, 25);
            rbdDias.TabIndex = 5;
            rbdDias.TabStop = true;
            rbdDias.Text = "Dias";
            rbdDias.UseVisualStyleBackColor = true;
            // 
            // rbdMeses
            // 
            rbdMeses.AutoSize = true;
            rbdMeses.Location = new Point(24, 540);
            rbdMeses.Margin = new Padding(6, 8, 6, 8);
            rbdMeses.Name = "rbdMeses";
            rbdMeses.Size = new Size(72, 25);
            rbdMeses.TabIndex = 6;
            rbdMeses.TabStop = true;
            rbdMeses.Text = "Meses";
            rbdMeses.UseVisualStyleBackColor = true;
            // 
            // rbdAnio
            // 
            rbdAnio.AutoSize = true;
            rbdAnio.Location = new Point(24, 658);
            rbdAnio.Margin = new Padding(6, 8, 6, 8);
            rbdAnio.Name = "rbdAnio";
            rbdAnio.Size = new Size(63, 25);
            rbdAnio.TabIndex = 7;
            rbdAnio.TabStop = true;
            rbdAnio.Text = "Años";
            rbdAnio.UseVisualStyleBackColor = true;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(482, 647);
            txtIncremento.Margin = new Padding(6, 8, 6, 8);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(274, 29);
            txtIncremento.TabIndex = 8;
            // 
            // btnIncrementar
            // 
            btnIncrementar.BackColor = SystemColors.ActiveCaption;
            btnIncrementar.Location = new Point(267, 734);
            btnIncrementar.Margin = new Padding(6, 8, 6, 8);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(492, 94);
            btnIncrementar.TabIndex = 9;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = false;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 903);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 10;
            label4.Text = "Fecha Final";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(24, 952);
            txtFechaFinal.Margin = new Padding(6, 8, 6, 8);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(669, 29);
            txtFechaFinal.TabIndex = 11;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 1031);
            Controls.Add(txtFechaFinal);
            Controls.Add(label4);
            Controls.Add(btnIncrementar);
            Controls.Add(txtIncremento);
            Controls.Add(rbdAnio);
            Controls.Add(rbdMeses);
            Controls.Add(rbdDias);
            Controls.Add(label3);
            Controls.Add(checkFormato);
            Controls.Add(txtFecha);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            Load += Form04DateTime_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFecha;
        private System.Windows.Forms.CheckBox checkFormato;
        private Label label3;
        private RadioButton rbdDias;
        private RadioButton rbdMeses;
        private RadioButton rbdAnio;
        private TextBox txtIncremento;
        private System.Windows.Forms.Button btnIncrementar;
        private Label label4;
        private TextBox txtFechaFinal;
    }
}