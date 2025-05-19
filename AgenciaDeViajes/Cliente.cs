using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using static System.Net.Mime.MediaTypeNames;

namespace AgenciaDeViajes
{
    public partial class Cliente : Form
    {
        private CNcliente objetoCN = new CNcliente();
        private Boolean editar = false;
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            mostrarCliente();
        }
        private void mostrarCliente()
        {
            CNcliente objeto = new CNcliente();
            dataGridView1.DataSource = objeto.mostrarCliente();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarForm()
        {
            textNombre.Clear();
            textApellido.Clear();
            textDireccion.Clear();
            textPasaporte.Clear();
            textTelf.Clear();
            textCorreo.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    objetoCN.InsertarCliente(textNombre.Text, textApellido.Text, textDireccion.Text, textPasaporte.Text, textTelf.Text, textCorreo.Text);
                    MessageBox.Show("Se inserto Correctamente");
                    mostrarCliente();
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
                    objetoCN.modificarCliente(textNombre.Text, textApellido.Text, textDireccion.Text, textPasaporte.Text, textTelf.Text, textCorreo.Text,textId.Text);
                    MessageBox.Show("Se edito correctamente");
                    mostrarCliente();
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
                textApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                textDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                textPasaporte.Text = dataGridView1.CurrentRow.Cells["Pasaporte"].Value.ToString();
                textTelf.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                textCorreo.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                textId.Text = dataGridView1.CurrentRow.Cells["ID_Cliente"].Value.ToString();

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
                textId.Text = dataGridView1.CurrentRow.Cells["ID_Cliente"].Value.ToString();
                objetoCN.eliminarClien(textId.Text);
                MessageBox.Show("Se elimino correctamente");
                mostrarCliente();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva();
            reserva.Show();
        }
    }
}
