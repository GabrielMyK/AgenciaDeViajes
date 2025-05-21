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
    public partial class interfaz : Form
    {
        public interfaz()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void interfaz_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Viaje viaje = new Viaje();
            viaje.Show();  
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva(); 
            reserva.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Guia guia = new Guia();
            guia.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transporte transporte = new Transporte();
            transporte.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Alojamiento alojamiento = new Alojamiento();    
            alojamiento.Show();
        }
    }
}
