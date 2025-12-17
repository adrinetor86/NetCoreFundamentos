namespace NetCoreFundamentos
{
    partial class Form11ColeccionMultiple
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
            lblIndex = new Label();
            lblitem = new Label();
            btnBorrar = new Button();
            btnEliminar = new Button();
            label2 = new Label();
            txtNuevo = new TextBox();
            btnInsertar = new Button();
            label1 = new Label();
            lstElementos = new ListBox();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(67, 307);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(49, 15);
            lblIndex.TabIndex = 17;
            lblIndex.Text = "lblIndex";
            // 
            // lblitem
            // 
            lblitem.AutoSize = true;
            lblitem.Location = new Point(71, 259);
            lblitem.Name = "lblitem";
            lblitem.Size = new Size(44, 15);
            lblitem.TabIndex = 16;
            lblitem.Text = "lblitem";
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(253, 186);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(134, 34);
            btnBorrar.TabIndex = 15;
            btnBorrar.Text = "Borrar Todo";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(253, 148);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 32);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 20);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 13;
            label2.Text = "Nuevo Elemento";
            // 
            // txtNuevo
            // 
            txtNuevo.Location = new Point(253, 59);
            txtNuevo.Name = "txtNuevo";
            txtNuevo.Size = new Size(128, 23);
            txtNuevo.TabIndex = 12;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(253, 108);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(134, 34);
            btnInsertar.TabIndex = 11;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 20);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 10;
            label1.Text = "Elementos";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(43, 61);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(120, 154);
            lstElementos.TabIndex = 9;
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(253, 226);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(134, 34);
            btnSeleccionados.TabIndex = 18;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // Form11ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 394);
            Controls.Add(btnSeleccionados);
            Controls.Add(lblIndex);
            Controls.Add(lblitem);
            Controls.Add(btnBorrar);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(txtNuevo);
            Controls.Add(btnInsertar);
            Controls.Add(label1);
            Controls.Add(lstElementos);
            Name = "Form11ColeccionMultiple";
            Text = "Form11ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIndex;
        private Label lblitem;
        private Button btnBorrar;
        private Button btnEliminar;
        private Label label2;
        private TextBox txtNuevo;
        private Button btnInsertar;
        private Label label1;
        private ListBox lstElementos;
        private Button btnSeleccionados;
    }
}