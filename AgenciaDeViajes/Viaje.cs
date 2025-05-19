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
    public partial class Viaje : Form
    {
        private CNviaje objetoCN = new CNviaje();
        private Boolean editar=false;
        public Viaje()
        {
            InitializeComponent();
        }

        private void Viaje_Load(object sender, EventArgs e)
        {
            MostrarViaje();
        }

        public void MostrarViaje()
        {
            CNviaje objeto = new CNviaje();
            dataGridView1.DataSource = objeto.mostrarViaje();
        }

        private void textSalida_TextChanged(object sender, EventArgs e)
        {

        }

        private void textRegreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void LimpiarForm()
        {
            textDestino.Clear();
            textSalida.Clear();
            textRegreso.Clear();
            textDescripcion.Clear();
            textGuia.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    objetoCN.InsertarViaje(textDestino.Text, textSalida.Text, textRegreso.Text, textDescripcion.Text, textGuia.Text);
                    MessageBox.Show("Se inserto Correctamente");
                    MostrarViaje();
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
                    objetoCN.editarViaje(textDestino.Text, textSalida.Text, textRegreso.Text, textDescripcion.Text, textGuia.Text, textIdViaje.Text);
                    MessageBox.Show("Se edito correctamente");
                    MostrarViaje();
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
                textDestino.Text = dataGridView1.CurrentRow.Cells["Destino"].Value.ToString();
                textSalida.Text = dataGridView1.CurrentRow.Cells["Fecha_Salida"].Value.ToString();
                textRegreso.Text = dataGridView1.CurrentRow.Cells["Fecha_Regreso"].Value.ToString();
                textDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                textGuia.Text = dataGridView1.CurrentRow.Cells["ID_Guia"].Value.ToString();
                textIdViaje.Text = dataGridView1.CurrentRow.Cells["ID_Viaje"].Value.ToString();

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
                textIdViaje.Text = dataGridView1.CurrentRow.Cells["ID_Viaje"].Value.ToString();
                objetoCN.eliminarViaje(textIdViaje.Text);
                MessageBox.Show("Se elimino correctamente");
                MostrarViaje();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
