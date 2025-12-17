namespace NetCoreFundamentos
{
    partial class Form10ColeccionGrafica
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
            lstElementos = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            btnInsertar = new System.Windows.Forms.Button();
            txtNuevo = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnEliminar = new System.Windows.Forms.Button();
            btnBorrar = new System.Windows.Forms.Button();
            lblitem = new System.Windows.Forms.Label();
            lblIndex = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new System.Drawing.Point(28, 101);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new System.Drawing.Size(120, 154);
            lstElementos.TabIndex = 0;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Elementos";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new System.Drawing.Point(238, 148);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new System.Drawing.Size(134, 34);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtNuevo
            // 
            txtNuevo.Location = new System.Drawing.Point(238, 99);
            txtNuevo.Name = "txtNuevo";
            txtNuevo.Size = new System.Drawing.Size(128, 23);
            txtNuevo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(238, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 15);
            label2.TabIndex = 4;
            label2.Text = "Nuevo Elemento";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(238, 188);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(134, 32);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new System.Drawing.Point(238, 226);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new System.Drawing.Size(134, 34);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "Borrar Todo";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // lblitem
            // 
            lblitem.AutoSize = true;
            lblitem.Location = new System.Drawing.Point(56, 299);
            lblitem.Name = "lblitem";
            lblitem.Size = new System.Drawing.Size(44, 15);
            lblitem.TabIndex = 7;
            lblitem.Text = "lblitem";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new System.Drawing.Point(52, 347);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new System.Drawing.Size(49, 15);
            lblIndex.TabIndex = 8;
            lblIndex.Text = "lblIndex";
            // 
            // Form10ColeccionGrafica
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(416, 403);
            Controls.Add(lblIndex);
            Controls.Add(lblitem);
            Controls.Add(btnBorrar);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(txtNuevo);
            Controls.Add(btnInsertar);
            Controls.Add(label1);
            Controls.Add(lstElementos);
            Text = "Form10ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstElementos;
        private Label label1;
        private Button btnInsertar;
        private TextBox txtNuevo;
        private Label label2;
        private Button btnEliminar;
        private Button btnBorrar;
        private Label lblitem;
        private Label lblIndex;
    }
}