using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseDatos;
using BaseDatos.Accesos;
using BaseDatos.Entidades;
namespace Ejercicio_N_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aceptarbutton_Click(object sender, EventArgs e)
        {
            Coneccion coneccion = new Coneccion();
            Usuarios usuarios = new Usuarios();

            usuarios = coneccion.Login(usuariotextBox.Text, clavetextBox.Text);

            if (usuarios == null)
            {
                MessageBox.Show("Datos Incorrectos");
                return;
            }

            Usuarios2 usuarios2 = new Usuarios2();
            usuarios2.Show();

        }

        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
