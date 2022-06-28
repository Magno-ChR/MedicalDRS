
namespace MedicalDRS
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu_registro = new FontAwesome.Sharp.IconMenuItem();
            this.menu_cita = new FontAwesome.Sharp.IconMenuItem();
            this.menu_areas = new FontAwesome.Sharp.IconMenuItem();
            this.menu_perfil = new FontAwesome.Sharp.IconMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.text_usuario = new System.Windows.Forms.Label();
            this.menu_usuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_registro,
            this.menu_cita,
            this.menu_areas,
            this.menu_perfil,
            this.menu_usuarios});
            this.menu.Location = new System.Drawing.Point(0, 71);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1052, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menu_registro
            // 
            this.menu_registro.AutoSize = false;
            this.menu_registro.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.menu_registro.IconColor = System.Drawing.Color.Black;
            this.menu_registro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_registro.IconSize = 50;
            this.menu_registro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_registro.Name = "menu_registro";
            this.menu_registro.Size = new System.Drawing.Size(80, 69);
            this.menu_registro.Text = "Registro";
            this.menu_registro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_registro.Click += new System.EventHandler(this.menu_registro_Click);
            // 
            // menu_cita
            // 
            this.menu_cita.AutoSize = false;
            this.menu_cita.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.menu_cita.IconColor = System.Drawing.Color.Black;
            this.menu_cita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_cita.IconSize = 50;
            this.menu_cita.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_cita.Name = "menu_cita";
            this.menu_cita.Size = new System.Drawing.Size(80, 69);
            this.menu_cita.Text = "Cita";
            this.menu_cita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_areas
            // 
            this.menu_areas.AutoSize = false;
            this.menu_areas.IconChar = FontAwesome.Sharp.IconChar.Hospital;
            this.menu_areas.IconColor = System.Drawing.Color.Black;
            this.menu_areas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_areas.IconSize = 50;
            this.menu_areas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_areas.Name = "menu_areas";
            this.menu_areas.Size = new System.Drawing.Size(80, 69);
            this.menu_areas.Text = "Áreas";
            this.menu_areas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_perfil
            // 
            this.menu_perfil.AutoSize = false;
            this.menu_perfil.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.menu_perfil.IconColor = System.Drawing.Color.Black;
            this.menu_perfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_perfil.IconSize = 50;
            this.menu_perfil.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_perfil.Name = "menu_perfil";
            this.menu_perfil.Size = new System.Drawing.Size(80, 69);
            this.menu_perfil.Text = "Perfil";
            this.menu_perfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_perfil.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.DarkRed;
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1052, 71);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "MEDICAL DRS";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 144);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1052, 517);
            this.contenedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(599, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bienvenido:";
            // 
            // text_usuario
            // 
            this.text_usuario.AutoSize = true;
            this.text_usuario.BackColor = System.Drawing.Color.DarkRed;
            this.text_usuario.Font = new System.Drawing.Font("Montserrat Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_usuario.ForeColor = System.Drawing.Color.White;
            this.text_usuario.Location = new System.Drawing.Point(605, 38);
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.Size = new System.Drawing.Size(93, 16);
            this.text_usuario.TabIndex = 5;
            this.text_usuario.Text = "text_usuario";
            // 
            // menu_usuarios
            // 
            this.menu_usuarios.AutoSize = false;
            this.menu_usuarios.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.menu_usuarios.IconColor = System.Drawing.Color.Black;
            this.menu_usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_usuarios.IconSize = 50;
            this.menu_usuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_usuarios.Name = "menu_usuarios";
            this.menu_usuarios.Size = new System.Drawing.Size(80, 69);
            this.menu_usuarios.Text = "Usuarios";
            this.menu_usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 661);
            this.Controls.Add(this.text_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menutitulo;
        private FontAwesome.Sharp.IconMenuItem menu_perfil;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menu_registro;
        private FontAwesome.Sharp.IconMenuItem menu_cita;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label text_usuario;
        private FontAwesome.Sharp.IconMenuItem menu_areas;
        private FontAwesome.Sharp.IconMenuItem menu_usuarios;
    }
}

