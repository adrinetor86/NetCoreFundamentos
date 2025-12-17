using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text;

            if (!this.lstTienda.Items.Contains(producto))
            {
                this.lstTienda.Items.Add(producto);    
            };
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            int numProductos = this.lstTienda.SelectedIndices.Count-1;
       
            for (int i= numProductos; i >= 0 ;i--)
            {
                this.lstAlmacen.Items.Add(this.lstTienda.SelectedItems[i]);
                //ELIMINAMOS DE LA COLECCION
                
                
                int index = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(index);
            }
            MessageBox.Show(numProductos.ToString());
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {

        }

        private void btnSubir_Click(object sender, EventArgs e)
        {

        }

        private void btnBajar_Click(object sender, EventArgs e)
        {

        }

        private void lstTienda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
