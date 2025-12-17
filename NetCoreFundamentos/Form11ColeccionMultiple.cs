using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            //LA LISTA TENDRA SELECCION MULTIPLE
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtNuevo.Text;
            this.lstElementos.Items.Add(elem);

            this.txtNuevo.Focus();
            this.txtNuevo.SelectAll();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //QUIERO ELIMINAR LOS ELEMENTOS SELECCIONADOS
            //PARA LAS ACCIONES SOBRE LAS COLECCIONES SIEMPRE 
            //CON BUCLE CONTADOR
            //VOY A UTILIZAR EL METODO RemoveAt POR LO QUE RECORREMOS
            //LA COLECCION SelectedIndices

            int numElementos = this.lstElementos.SelectedIndices.Count - 1;
            for (int i= numElementos; i >= 0 ;i--)
            {
                int index = this.lstElementos.SelectedIndices[i];
                
                //ELIMINAMOS DE LA COLECCION
                this.lstElementos.Items.RemoveAt(index);
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            //VAMOS A RECORRER LA COLECCION DE ITEMS SELECCIONADOS
            
            foreach (string item in this.lstElementos.SelectedItems)
            {
                items += item + " ,";
            }
            //VISUALIZAMOS LOS INDICES SELECCIONADOS
            foreach (int index in this.lstElementos.SelectedIndices)
            {
                indices += index + " ,";
            }
            this.lblIndex.Text = indices.Trim(',');
            this.lblitem.Text = items.Trim(',');
        }
    }
}
