using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace AgenciaDeViajes
{
    public partial class Usuario : Form
    {
        private CNusuario objetoCN=new CNusuario();
        private Boolean editar=false;
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            MostrarUsuario();
        }
        private void MostrarUsuario()
        {
            CNusuario objeto = new CNusuario();
            dataGridView1.DataSource = objeto.mostrarUsuario();  
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void LimpiarForm()
        {
            textNombre.Clear();
            textCargo.Clear();
            textTelf.Clear();
            textCorreo.Clear();
            textContra.Clear();

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if(editar== false)
            {
                try
                {
                    objetoCN.InsertarUsu(textNombre.Text, textCargo.Text, textTelf.Text, textCorreo.Text, textContra.Text);
                    MessageBox.Show("Se inserto Correctamente");
                    MostrarUsuario();
                    LimpiarForm();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se pudo Insertar" + ex);
                }
            }
            if (editar==true)
            {
                try
                {
                    objetoCN.modificarUsu(textNombre.Text, textCargo.Text, textTelf.Text, textCorreo.Text, textContra.Text,textId.Text);
                    MessageBox.Show("Se edito correctamente");
                    MostrarUsuario();
                    editar = false;
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nose pudo editar por: " + ex);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                editar = true;
                textNombre.Text= dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                textCargo.Text = dataGridView1.CurrentRow.Cells["cargo"].Value.ToString();
                textTelf.Text = dataGridView1.CurrentRow.Cells["telefono"].Value.ToString();
                textCorreo.Text = dataGridView1.CurrentRow.Cells["correo"].Value.ToString();
                textContra.Text = dataGridView1.CurrentRow.Cells["contraseña"].Value.ToString();
                textId.Text = dataGridView1.CurrentRow.Cells["idUsuario"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textId.Text = dataGridView1.CurrentRow.Cells["idUsuario"].Value.ToString();
                objetoCN.eliminarUsu(textId.Text);
                MessageBox.Show("Se elimino correctamente");
                MostrarUsuario();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
