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
using static System.Net.Mime.MediaTypeNames;

namespace AgenciaDeViajes
{
    public partial class Alojamiento : Form
    {
        private CNalojamiento objetoCN = new CNalojamiento();
        private Boolean editar = false;

        public Alojamiento()
        {
            InitializeComponent();
        }

        private void LimpiarForm()
        {
            textNombre.Clear();
            textDireccion.Clear();
            textPrecio.Clear();
            textTelf.Clear();
            textTipo.Clear();
            textViaje.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (editar==false)
            {
                try
                {
                    objetoCN.insertarAloja(textNombre.Text, textDireccion.Text, textPrecio.Text, textTelf.Text, textTipo.Text, textViaje.Text);
                    MessageBox.Show("Se inserto correctamente");
                    mostrarAloja();
                    LimpiarForm();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nose pudo insertar" + ex);
                }
            }
            if (editar == true)
            {
                try
                {
                    objetoCN.editarAloja(textNombre.Text, textDireccion.Text, textPrecio.Text, textTelf.Text, textTipo.Text, textViaje.Text,textAloja.Text);
                    MessageBox.Show("Se edito correctamente");
                    mostrarAloja();
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nose pudo editar" + ex);
                }
            }
        }

        private void Alojamiento_Load(object sender, EventArgs e)
        {
            mostrarAloja();
        }

        public void mostrarAloja()
        {
            CNalojamiento objeto = new CNalojamiento();
            dataGridView1.DataSource = objeto.mostrarAlojamiento();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                textNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                textDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                textPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                textTelf.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                textTipo.Text = dataGridView1.CurrentRow.Cells["Tipo"].Value.ToString();
                textViaje.Text = dataGridView1.CurrentRow.Cells["ID_Viaje"].Value.ToString();
                textAloja.Text = dataGridView1.CurrentRow.Cells["ID_Alojamiento"].Value.ToString();

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
                textAloja.Text = dataGridView1.CurrentRow.Cells["ID_Alojamiento"].Value.ToString();
                objetoCN.eliminarAloja(textAloja.Text);
                MessageBox.Show("Se elimino correctamente");
                mostrarAloja();

            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
