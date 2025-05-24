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
    public partial class Pago : Form
    {
        private CNpago objetoCN = new CNpago(); 
        private Boolean editar= false;
        public Pago()
        {
            InitializeComponent();
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            mostrarPago();
            cargarViaje();
            cargarReserva();
        }

        private void cargarViaje()
        {
            CNviaje viaje = new CNviaje();
            comboIdViaje.DataSource = viaje.mostrarViaje();
            comboIdViaje.DisplayMember = "Destino";
            comboIdViaje.ValueMember = "ID_Viaje";
        }
        private void cargarReserva()
        {
            CNreserva reserva = new CNreserva();
            comboIdReserva.DataSource = reserva.mostrarReserva();
            comboIdReserva.ValueMember = "ID_Reserva";
        }

        private void LimpiarForm()
        {
            textMonto.Clear();
            textMetodoPago.Clear();
        }

        public void mostrarPago()
        {
            CNpago objetoCN = new CNpago();
            dataGridView1.DataSource = objetoCN.mostrarPago();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    string idReserva = comboIdReserva.SelectedValue.ToString();
                    string idViaje = comboIdViaje.SelectedValue.ToString() ;
                    objetoCN.insertarPago(idReserva,idViaje,dateTimePicker1.Text,textMonto.Text,textMetodoPago.Text);
                    MessageBox.Show("Se inserto Correctamente");
                    mostrarPago();
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
                    string idReserva = comboIdReserva.SelectedValue.ToString();
                    string idViaje = comboIdViaje.SelectedValue.ToString();
                    objetoCN.editarPago(idReserva,idViaje, dateTimePicker1.Text, textMonto.Text, textMetodoPago.Text,textIdPago.Text);
                    MessageBox.Show("Se edito correctamente");
                    mostrarPago();
                    editar = false;
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nose pudo editar por: " + ex);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                comboIdReserva.SelectedValue = dataGridView1.CurrentRow.Cells["ID_Reserva"].Value.ToString();
                comboIdViaje.SelectedValue = dataGridView1.CurrentRow.Cells["ID_Viaje"].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["Fecha_Pago"].Value.ToString();
                textMonto.Text = dataGridView1.CurrentRow.Cells["Monto"].Value.ToString();
                textMetodoPago.Text = dataGridView1.CurrentRow.Cells["Metodo_Pago"].Value.ToString();
                textIdPago.Text = dataGridView1.CurrentRow.Cells["ID_Pago"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textIdPago.Text = dataGridView1.CurrentRow.Cells["ID_Pago"].Value.ToString();
                objetoCN.eliminarPago(textIdPago.Text);
                MessageBox.Show("Se elimino correctamente");
                mostrarPago();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
