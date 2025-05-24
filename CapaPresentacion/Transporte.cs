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
    public partial class Transporte : Form
    {
        private CNtransporte objetoCN = new CNtransporte();
        private Boolean editar = false;
        public Transporte()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Transporte_Load(object sender, EventArgs e)
        {
            mostrarTransporte();
            CargarViaje();
        }
        private void CargarViaje()
        {
            CNviaje viaje = new CNviaje();
            comboIdViaje.DataSource = viaje.mostrarViaje();
            comboIdViaje.DisplayMember = "Destino";
            comboIdViaje.ValueMember = "ID_Viaje";
        }

        public void LimpiarForm()
        {
            textTipo.Clear();
        }

        public void mostrarTransporte()
        {
            CNtransporte objetoCN= new CNtransporte();
            dataGridView1.DataSource = objetoCN.mostrarTransporte();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    string idViaje = comboIdViaje.SelectedValue.ToString();
                    objetoCN.InsertarTransporte(textTipo.Text, idViaje);
                    MessageBox.Show("Se inserto Correctamente");
                    mostrarTransporte();
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
                    string idViaje = comboIdViaje.SelectedValue.ToString();
                    objetoCN.editarTrans(textTipo.Text, textIdTrans.Text, idViaje);
                    MessageBox.Show("Se edito correctamente");
                    mostrarTransporte();
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
                textIdTrans.Text = dataGridView1.CurrentRow.Cells["ID_Transporte"].Value.ToString();
                textTipo.Text = dataGridView1.CurrentRow.Cells["Tipo"].Value.ToString();
                comboIdViaje.SelectedValue = dataGridView1.CurrentRow.Cells["ID_Viaje"].Value.ToString();
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
                textIdTrans.Text = dataGridView1.CurrentRow.Cells["ID_Transporte"].Value.ToString();
                objetoCN.eliminarTrans(textIdTrans.Text);
                MessageBox.Show("Se elimino correctamente");
                mostrarTransporte();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void textIdViaje_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
