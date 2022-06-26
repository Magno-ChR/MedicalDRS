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
using CapaEntidad;

namespace MedicalDRS
{
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_acceder_Click(object sender, EventArgs e)
        {

            Usuario Objusuario = new CN_Usuario().Listar().Where(u => u.Correo == txt_correo.Text && u.Clave == txt_clave.Text).FirstOrDefault();
            if(Objusuario != null)
            {
                /*
             Creamos una instancia del formulario Inicio
             */
                Inicio form = new Inicio();
                //Mostramos inicio
                form.Show();
                //Ocultamos Acceso
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("Datos Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txt_clave.Text = "";

            this.Show();
        }
    }
}
