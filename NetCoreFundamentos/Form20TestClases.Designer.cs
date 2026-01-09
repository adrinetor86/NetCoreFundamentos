namespace NetCoreFundamentos
{
    partial class Form20TestClases
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
            btnCrear = new Button();
            label1 = new Label();
            lstClases = new ListBox();
            btnEmpleado = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(73, 218);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(136, 35);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear Persona";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 38);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "Datos";
            // 
            // lstClases
            // 
            lstClases.FormattingEnabled = true;
            lstClases.Location = new Point(73, 83);
            lstClases.Name = "lstClases";
            lstClases.Size = new Size(331, 124);
            lstClases.TabIndex = 2;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Location = new Point(244, 218);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(118, 35);
            btnEmpleado.TabIndex = 3;
            btnEmpleado.Text = "Empleado";
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // button1
            // 
            button1.Location = new Point(157, 271);
            button1.Name = "button1";
            button1.Size = new Size(131, 36);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form20TestClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 356);
            Controls.Add(button1);
            Controls.Add(btnEmpleado);
            Controls.Add(lstClases);
            Controls.Add(label1);
            Controls.Add(btnCrear);
            Name = "Form20TestClases";
            Text = "Form20TestClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrear;
        private Label label1;
        private ListBox lstClases;
        private Button btnEmpleado;
        private Button button1;
    }
}