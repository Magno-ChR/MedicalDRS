using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;

namespace MedicalDRS
{
    public partial class Inicio : Form
    {
        private static Usuario UsuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio(Usuario Objusuario)
        {
            UsuarioActual = Objusuario;

            InitializeComponent();
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormulario(IconMenuItem menu , Form formulario)
        {

            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.DarkSalmon;
            MenuActivo = menu;

            if(FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            //CONFUGURACION DEL FORMULARIO
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.DarkRed;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menu_registro_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmRegistro());
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

            //CONTROL DE ACCESO 111 = ADMINISTRADOR 222 = DOCTOR 333 = RECEPCION
            Usuario Objusuario = new CN_Usuario().Listar().Where(u => u.IdUsuario == UsuarioActual.IdUsuario).FirstOrDefault();

            if(Objusuario.CodPermisos != 111)
            {
                menu_usuarios.Visible = false;
            }


            int Id = UsuarioActual.IdPersona;
            Persona Objpersona = new CN_Persona().Listar().Where(u => u.IdPersona == Id).FirstOrDefault();

            text_usuario.Text = Objpersona.Nombres +" "+ Objpersona.ApellidoP;
        }
    }
}
