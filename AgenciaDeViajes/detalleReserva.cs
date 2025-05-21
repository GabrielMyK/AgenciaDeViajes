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
    public partial class detalleReserva : Form
    {
        private CNdetalle objetoCN = new CNdetalle();
        private Boolean editar = false; 
        public detalleReserva()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void detalleReserva_Load(object sender, EventArgs e)
        {
            mostrarDetalle();
            cargarReserva();
        }
        private void cargarReserva()
        {
            CNreserva reserva = new CNreserva();
            comboIdReserva.DataSource = reserva.mostrarReserva();
            comboIdReserva.ValueMember = "ID_Reserva";
        }

        public void LimpiarForm()
        {
            textCantidad.Clear();
            textHabitacion.Clear();
            textServicio.Clear();
            textPagoExtra.Clear();
        }
        private void mostrarDetalle()
        {
            CNdetalle objeto = new CNdetalle();
            dataGridView1.DataSource = objeto.mostrarDetalle();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                if (editar == false)
                {
                    try
                    {
                        string idReserva = comboIdReserva.SelectedValue.ToString();
                        objetoCN.InsertarDetalle(idReserva, textCantidad.Text, textHabitacion.Text, textServicio.Text, textPagoExtra.Text);
                        MessageBox.Show("Se inserto Correctamente");
                        mostrarDetalle();
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
                        objetoCN.editarDetalle(idReserva, textCantidad.Text, textHabitacion.Text, textServicio.Text, textPagoExtra.Text,textIdDetalle.Text);
                        MessageBox.Show("Se edito correctamente");
                        mostrarDetalle();
                        editar = false;
                        LimpiarForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nose pudo editar por: " + ex);
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                comboIdReserva.SelectedValue = dataGridView1.CurrentRow.Cells["idReserva"].Value.ToString();
                textCantidad.Text = dataGridView1.CurrentRow.Cells["CantidadPersonas"].Value.ToString();
                textHabitacion.Text = dataGridView1.CurrentRow.Cells["TipoHabitacion"].Value.ToString();
                textServicio.Text = dataGridView1.CurrentRow.Cells["ServicioExtra"].Value.ToString();
                textPagoExtra.Text = dataGridView1.CurrentRow.Cells["CostoExtra"].Value.ToString();
                textIdDetalle.Text = dataGridView1.CurrentRow.Cells["idDetalle"].Value.ToString();
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
                textIdDetalle.Text = dataGridView1.CurrentRow.Cells["idDetalle"].Value.ToString();
                objetoCN.eliminarDetalle(textIdDetalle.Text);
                MessageBox.Show("Se elimino correctamente");
                mostrarDetalle();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
