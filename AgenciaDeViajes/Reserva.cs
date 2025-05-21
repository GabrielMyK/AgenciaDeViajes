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
    public partial class Reserva : Form
    {
        private CNreserva objetoCN = new CNreserva();
        private Boolean editar = false;
        public Reserva()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                textIdCliente.Text = dataGridView1.CurrentRow.Cells["ID_Cliente"].Value.ToString();
                textIdViaje.Text = dataGridView1.CurrentRow.Cells["ID_Viaje"].Value.ToString();
                textPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                textReserva.Text = dataGridView1.CurrentRow.Cells["Fecha_Reserva"].Value.ToString();
                textIdReserva.Text = dataGridView1.CurrentRow.Cells["ID_Reserva"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            mostrarReserva();
            CargarCliente();
            CargarViaje();
        }
        private void CargarCliente ()
        {
            CNcliente cliente = new CNcliente();
            comboIdCliente.DataSource = cliente.mostrarCliente();
            comboIdCliente.DisplayMember = "Nombre";     
            comboIdCliente.ValueMember = "ID_Cliente";   
        }
        private void CargarViaje()
        {
            CNviaje viaje = new CNviaje();
            comboIdViaje.DataSource = viaje.mostrarViaje();
            comboIdViaje.DisplayMember = "Destino";
            comboIdViaje.ValueMember = "ID_Viaje";
        }


        public void mostrarReserva()
        {
            CNreserva objeto = new CNreserva();
            dataGridView1.DataSource = objeto.mostrarReserva();
        }
        private void LimpiarForm()
        {
            textIdCliente.Clear();
            textIdViaje.Clear();
            textPrecio.Clear();
            textReserva.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    string idCliente = comboIdCliente.SelectedValue.ToString();
                    string idViaje = comboIdViaje.SelectedValue.ToString();
                    objetoCN.InsertarReserva(idCliente,idViaje, textPrecio.Text, dateTimePicker1.Text);
                    MessageBox.Show("Se inserto Correctamente");
                    mostrarReserva();
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
                    objetoCN.editarReserva(textIdCliente.Text, textIdViaje.Text, textPrecio.Text, textReserva.Text, textIdReserva.Text);
                    MessageBox.Show("Se edito correctamente");
                    mostrarReserva();
                    editar = false;
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nose pudo editar por: " + ex);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textIdReserva.Text = dataGridView1.CurrentRow.Cells["ID_Reserva"].Value.ToString();
                objetoCN.eliminarReserva(textIdReserva.Text);
                MessageBox.Show("Se elimino correctamente");
                mostrarReserva();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
