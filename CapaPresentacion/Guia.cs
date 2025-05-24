using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaDeViajes
{
    public partial class Guia : Form
    {
        private CNguia objetoCN = new CNguia();
        private Boolean editar= false;  
        public Guia()
        {
            InitializeComponent();
        }

        private void Guia_Load(object sender, EventArgs e)
        {
            mostrarGuia();
        }

        private void mostrarGuia()
        {
            CNguia objeto= new CNguia();
            dataGridView1.DataSource = objeto.mostrarGuia();
        }

        private void LimpiarForm()
        {
            textNombre.Clear();
            textTelf.Clear();
            textIdioma.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    objetoCN.InsertarGuia(textNombre.Text, textTelf.Text, textIdioma.Text);
                    MessageBox.Show("Se inserto Correctamente");
                    mostrarGuia();
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo Insertar" + ex);
                }
            }
            if (editar == true)
            {
                try
                {
                    objetoCN.editarGuia(textNombre.Text, textTelf.Text, textIdioma.Text, textId.Text);
                    MessageBox.Show("Se edito correctamente");
                    mostrarGuia();
                    editar = false;
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nose pudo editar por: " + ex);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                textNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                textTelf.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                textIdioma.Text = dataGridView1.CurrentRow.Cells["Idioma"].Value.ToString();
                textId.Text = dataGridView1.CurrentRow.Cells["ID_Guia"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textId.Text = dataGridView1.CurrentRow.Cells["ID_Guia"].Value.ToString();
                objetoCN.eliminarGuia(textId.Text);
                MessageBox.Show("Se elimino correctamente");
                mostrarGuia();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
