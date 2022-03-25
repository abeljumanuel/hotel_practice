using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2_Juan_Rojas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            if (txtclave.Text != "") // Validar si se ha diligenciado el campo contraseña
            {
                if (txtclave.Text == "123") // Validar Contraseña
                {
                    HotelEstadia est = new(); // Invocar el formulario HotelEstadia
                    est.Show(); // Mostrar el Formulario HotelEstadia
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Por favor digite la contraseña correcta"); // Informar al usuario error al digitar contraseña
                    txtclave.Focus(); // Llevar al Campo
                    txtclave.Clear(); // Limpiar el campo
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese una contraseña"); // Informar al usuario contraseña vacia
                txtclave.Focus(); // Llevar al Campo
            }
        }
    }
}
