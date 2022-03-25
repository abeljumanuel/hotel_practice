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
    public partial class HotelEstadia : Form
    {
        Persona P = new(); // Declaro la clase como pública para poder hacer uso de ella en otros metodos
        public HotelEstadia()
        {
            InitializeComponent();
            btncalculate.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            if (Validate() == 1)
            {
                P.id = txtid.Text;
                P.name = txtname.Text;
                P.tproom = cmbtproom.Text;
                P.value = Convert.ToInt32(txtvalue.Text);
                if (optman.Checked == true)
                    P.sex = "Masculino";
                else
                    P.sex = "Femenino";
                P.days = Convert.ToInt32(txtdays.Text);
                txtid.Enabled = false;
                txtname.Enabled = false;
                cmbtproom.Enabled = false;
                txtdays.Enabled = false;
                grpsex.Enabled = false;
                btncalculate.Enabled = true;

                MessageBox.Show("Se ha cargado el Registro de manera Satisfactoria");
            }
        }
        public new int Validate()
        {
            int b = 0;
            if (txtid.Text == "")
            {
                MessageBox.Show("Falta Agregar dato Cédula");
                txtid.Focus();
            }
            else if (txtname.Text == "")
            {
                MessageBox.Show("Falta Agregar dato Nombre y Apellido");
                txtname.Focus();
            }
            else if (txtdays.Text == "")
            {
                MessageBox.Show("Falta Agregar cantidad días hospedaje");
                txtdays.Focus();
            }
            else if (txtvalue.Text == "")
            {
                MessageBox.Show("Falta el tipo de habitación");
                cmbtproom.Focus();
            }
            else if (optman.Checked == false && optwoman.Checked == false)
            {
                MessageBox.Show("Falta seleccionar un genero");
                grpsex.Focus();
            }
            else
                b = 1;
            return b;
        }

        private void cmbtproom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtproom.Text == "Sencilla"){
                txtvalue.Text = "70000";
            }else if (cmbtproom.Text == "Doble"){
                txtvalue.Text = "90000";
            }
            else if (cmbtproom.Text == "Especial") {
                txtvalue.Text = "12000";
            }
            else {
                MessageBox.Show("Elija un tipo de habitación valido");
                cmbtproom.Focus();
            }
        }

        private void HotelEstadia_Load(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            ReporteHotelEstadia report = new(); // Invocar el ReporteHotelEstadia
            report.Show(); // Mostrar el ReporteHotelEstadia
            report.lbl_id.Text = P.id;
            report.lbl_name.Text = P.name;
            report.lbl_sex.Text = P.sex;
            report.lbl_tproom.Text = P.tproom;
            report.lbl_days.Text = Convert.ToString(P.days);
            report.lbl_totalvalue.Text = Convert.ToString(P.CalculateTotal(P.days,P.value));
            report.lbl_totalvalue2.Text = report.lbl_totalvalue.Text;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
