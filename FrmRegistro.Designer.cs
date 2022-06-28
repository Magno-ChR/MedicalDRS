
namespace MedicalDRS
{
    partial class FrmRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nroci = new System.Windows.Forms.TextBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_paterno = new System.Windows.Forms.TextBox();
            this.txt_materno = new System.Windows.Forms.TextBox();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.txt_proc = new System.Windows.Forms.TextBox();
            this.txt_fechanac = new System.Windows.Forms.DateTimePicker();
            this.btn_registrar = new FontAwesome.Sharp.IconButton();
            this.btn_actualizar = new FontAwesome.Sharp.IconButton();
            this.btn_eliminar = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_selecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaIdentidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procedencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 521);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Paterno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido Materno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de Nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de Carnet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lugar de Procedencia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Número de Celular:";
            // 
            // txt_nroci
            // 
            this.txt_nroci.Location = new System.Drawing.Point(12, 40);
            this.txt_nroci.Name = "txt_nroci";
            this.txt_nroci.Size = new System.Drawing.Size(200, 20);
            this.txt_nroci.TabIndex = 8;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(12, 100);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(200, 20);
            this.txt_nombres.TabIndex = 9;
            // 
            // txt_paterno
            // 
            this.txt_paterno.Location = new System.Drawing.Point(12, 160);
            this.txt_paterno.Name = "txt_paterno";
            this.txt_paterno.Size = new System.Drawing.Size(200, 20);
            this.txt_paterno.TabIndex = 10;
            // 
            // txt_materno
            // 
            this.txt_materno.Location = new System.Drawing.Point(12, 220);
            this.txt_materno.Name = "txt_materno";
            this.txt_materno.Size = new System.Drawing.Size(200, 20);
            this.txt_materno.TabIndex = 11;
            // 
            // txt_celular
            // 
            this.txt_celular.Location = new System.Drawing.Point(12, 400);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(200, 20);
            this.txt_celular.TabIndex = 14;
            // 
            // txt_proc
            // 
            this.txt_proc.Location = new System.Drawing.Point(12, 340);
            this.txt_proc.Name = "txt_proc";
            this.txt_proc.Size = new System.Drawing.Size(200, 20);
            this.txt_proc.TabIndex = 13;
            // 
            // txt_fechanac
            // 
            this.txt_fechanac.Location = new System.Drawing.Point(12, 280);
            this.txt_fechanac.Name = "txt_fechanac";
            this.txt_fechanac.Size = new System.Drawing.Size(200, 20);
            this.txt_fechanac.TabIndex = 12;
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.Color.White;
            this.btn_registrar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_registrar.IconColor = System.Drawing.Color.White;
            this.btn_registrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_registrar.IconSize = 30;
            this.btn_registrar.Location = new System.Drawing.Point(12, 429);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(200, 35);
            this.btn_registrar.TabIndex = 15;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_registrar.UseVisualStyleBackColor = false;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.Orange;
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.Color.White;
            this.btn_actualizar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_actualizar.IconColor = System.Drawing.Color.Black;
            this.btn_actualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_actualizar.Location = new System.Drawing.Point(12, 474);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(80, 35);
            this.btn_actualizar.TabIndex = 16;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = false;

            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Red;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_eliminar.IconColor = System.Drawing.Color.Black;
            this.btn_eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_eliminar.Location = new System.Drawing.Point(132, 474);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(80, 35);
            this.btn_eliminar.TabIndex = 17;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;

            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_selecionar,
            this.IdPersona,
            this.CedulaIdentidad,
            this.Nombres,
            this.ApellidoP,
            this.ApellidoM,
            this.FechaNac,
            this.Procedencia,
            this.NroCelular});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(227, 80);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(840, 441);
            this.dataGridView1.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(227, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(840, 37);
            this.label9.TabIndex = 19;
            this.label9.Text = "Registros en Sistema:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(179, 14);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(33, 20);
            this.txt_id.TabIndex = 20;
            this.txt_id.Visible = false;
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.HeaderText = "";
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.ReadOnly = true;
            this.btn_selecionar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btn_selecionar.Width = 30;
            // 
            // IdPersona
            // 
            this.IdPersona.HeaderText = "ID";
            this.IdPersona.Name = "IdPersona";
            this.IdPersona.ReadOnly = true;
            this.IdPersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdPersona.Visible = false;
            // 
            // CedulaIdentidad
            // 
            this.CedulaIdentidad.HeaderText = "Nro Carnet";
            this.CedulaIdentidad.Name = "CedulaIdentidad";
            this.CedulaIdentidad.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 120;
            // 
            // ApellidoP
            // 
            this.ApellidoP.HeaderText = "A. Paterno";
            this.ApellidoP.Name = "ApellidoP";
            this.ApellidoP.ReadOnly = true;
            this.ApellidoP.Width = 115;
            // 
            // ApellidoM
            // 
            this.ApellidoM.HeaderText = "A. Materno";
            this.ApellidoM.Name = "ApellidoM";
            this.ApellidoM.ReadOnly = true;
            this.ApellidoM.Width = 115;
            // 
            // FechaNac
            // 
            this.FechaNac.HeaderText = "F. Nacimiento";
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.ReadOnly = true;
            // 
            // Procedencia
            // 
            this.Procedencia.HeaderText = "Procedencia";
            this.Procedencia.Name = "Procedencia";
            this.Procedencia.ReadOnly = true;
            this.Procedencia.Width = 110;
            // 
            // NroCelular
            // 
            this.NroCelular.HeaderText = "Celular";
            this.NroCelular.Name = "NroCelular";
            this.NroCelular.ReadOnly = true;
            this.NroCelular.Width = 107;
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1067, 521);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_fechanac);
            this.Controls.Add(this.txt_proc);
            this.Controls.Add(this.txt_celular);
            this.Controls.Add(this.txt_materno);
            this.Controls.Add(this.txt_paterno);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.txt_nroci);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistro";
            this.Text = "FrmRegistro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nroci;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_paterno;
        private System.Windows.Forms.TextBox txt_materno;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.TextBox txt_proc;
        private System.Windows.Forms.DateTimePicker txt_fechanac;
        private FontAwesome.Sharp.IconButton btn_registrar;
        private FontAwesome.Sharp.IconButton btn_actualizar;
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridViewButtonColumn btn_selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaIdentidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procedencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCelular;
    }
}