namespace academico
{
    partial class FrmTutoria
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lb_asistencia = new System.Windows.Forms.Label();
            this.gbox_asistencia = new System.Windows.Forms.GroupBox();
            this.rb_no = new System.Windows.Forms.RadioButton();
            this.rb_si = new System.Windows.Forms.RadioButton();
            this.txt_tema = new System.Windows.Forms.RichTextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_am = new System.Windows.Forms.TextBox();
            this.txt_ap = new System.Windows.Forms.TextBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.cbdocente = new System.Windows.Forms.ComboBox();
            this.txt_docente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_menu = new System.Windows.Forms.Button();
            this.hora = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.gbox_asistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.txt_hora);
            this.panel1.Controls.Add(this.lbl_fecha);
            this.panel1.Controls.Add(this.lb_asistencia);
            this.panel1.Controls.Add(this.gbox_asistencia);
            this.panel1.Controls.Add(this.txt_tema);
            this.panel1.Controls.Add(this.txt_correo);
            this.panel1.Controls.Add(this.txt_am);
            this.panel1.Controls.Add(this.txt_ap);
            this.panel1.Controls.Add(this.txt_nombres);
            this.panel1.Controls.Add(this.cbdocente);
            this.panel1.Controls.Add(this.txt_docente);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_fecha);
            this.panel1.Controls.Add(this.txt_codigo);
            this.panel1.Controls.Add(this.lbl_hora);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(31, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 373);
            this.panel1.TabIndex = 62;
            // 
            // txt_hora
            // 
            this.txt_hora.Location = new System.Drawing.Point(83, 153);
            this.txt_hora.Margin = new System.Windows.Forms.Padding(4);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(204, 22);
            this.txt_hora.TabIndex = 82;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha.Location = new System.Drawing.Point(724, 70);
            this.lbl_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(84, 31);
            this.lbl_fecha.TabIndex = 81;
            this.lbl_fecha.Text = "Fecha";
            // 
            // lb_asistencia
            // 
            this.lb_asistencia.AutoSize = true;
            this.lb_asistencia.Location = new System.Drawing.Point(1050, 9);
            this.lb_asistencia.Name = "lb_asistencia";
            this.lb_asistencia.Size = new System.Drawing.Size(44, 16);
            this.lb_asistencia.TabIndex = 79;
            this.lb_asistencia.Text = "label1";
            this.lb_asistencia.Visible = false;
            // 
            // gbox_asistencia
            // 
            this.gbox_asistencia.Controls.Add(this.rb_no);
            this.gbox_asistencia.Controls.Add(this.rb_si);
            this.gbox_asistencia.Location = new System.Drawing.Point(682, 301);
            this.gbox_asistencia.Name = "gbox_asistencia";
            this.gbox_asistencia.Size = new System.Drawing.Size(200, 67);
            this.gbox_asistencia.TabIndex = 78;
            this.gbox_asistencia.TabStop = false;
            this.gbox_asistencia.Text = "Asistencia";
            // 
            // rb_no
            // 
            this.rb_no.AutoSize = true;
            this.rb_no.ForeColor = System.Drawing.Color.Black;
            this.rb_no.Location = new System.Drawing.Point(118, 32);
            this.rb_no.Name = "rb_no";
            this.rb_no.Size = new System.Drawing.Size(48, 20);
            this.rb_no.TabIndex = 78;
            this.rb_no.Text = "NO";
            this.rb_no.UseVisualStyleBackColor = true;
            // 
            // rb_si
            // 
            this.rb_si.AutoSize = true;
            this.rb_si.Checked = true;
            this.rb_si.ForeColor = System.Drawing.Color.Black;
            this.rb_si.Location = new System.Drawing.Point(24, 32);
            this.rb_si.Name = "rb_si";
            this.rb_si.Size = new System.Drawing.Size(40, 20);
            this.rb_si.TabIndex = 77;
            this.rb_si.TabStop = true;
            this.rb_si.Text = "SI";
            this.rb_si.UseVisualStyleBackColor = true;
            // 
            // txt_tema
            // 
            this.txt_tema.Location = new System.Drawing.Point(777, 178);
            this.txt_tema.Name = "txt_tema";
            this.txt_tema.Size = new System.Drawing.Size(283, 96);
            this.txt_tema.TabIndex = 76;
            this.txt_tema.Text = "";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(368, 199);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(132, 22);
            this.txt_correo.TabIndex = 75;
            // 
            // txt_am
            // 
            this.txt_am.Location = new System.Drawing.Point(368, 153);
            this.txt_am.Margin = new System.Windows.Forms.Padding(4);
            this.txt_am.Name = "txt_am";
            this.txt_am.Size = new System.Drawing.Size(132, 22);
            this.txt_am.TabIndex = 74;
            // 
            // txt_ap
            // 
            this.txt_ap.Location = new System.Drawing.Point(368, 112);
            this.txt_ap.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ap.Name = "txt_ap";
            this.txt_ap.Size = new System.Drawing.Size(132, 22);
            this.txt_ap.TabIndex = 73;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(368, 242);
            this.txt_nombres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(132, 22);
            this.txt_nombres.TabIndex = 72;
            // 
            // cbdocente
            // 
            this.cbdocente.FormattingEnabled = true;
            this.cbdocente.Location = new System.Drawing.Point(38, 70);
            this.cbdocente.Name = "cbdocente";
            this.cbdocente.Size = new System.Drawing.Size(249, 24);
            this.cbdocente.TabIndex = 70;
            this.cbdocente.SelectedIndexChanged += new System.EventHandler(this.cbdocente_SelectedIndexChanged);
            // 
            // txt_docente
            // 
            this.txt_docente.Location = new System.Drawing.Point(38, 112);
            this.txt_docente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_docente.Name = "txt_docente";
            this.txt_docente.Size = new System.Drawing.Size(249, 22);
            this.txt_docente.TabIndex = 65;
            this.txt_docente.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(747, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 31);
            this.label6.TabIndex = 62;
            this.label6.Text = "TUTORIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(563, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 31);
            this.label5.TabIndex = 61;
            this.label5.Text = "Recomendacion:";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(83, 184);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(204, 22);
            this.txt_fecha.TabIndex = 57;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(368, 70);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(132, 22);
            this.txt_codigo.TabIndex = 54;
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.White;
            this.lbl_hora.Location = new System.Drawing.Point(847, 112);
            this.lbl_hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(69, 31);
            this.lbl_hora.TabIndex = 53;
            this.lbl_hora.Text = "hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(372, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 52;
            this.label3.Text = "Alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 31);
            this.label2.TabIndex = 51;
            this.label2.Text = "Docentes:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(699, 458);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(429, 198);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(174, 405);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(114, 44);
            this.btn_agregar.TabIndex = 60;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(475, 405);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(125, 44);
            this.btneliminar.TabIndex = 58;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(319, 405);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(125, 44);
            this.btnmodificar.TabIndex = 57;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 468);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(640, 188);
            this.dataGridView2.TabIndex = 63;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(665, 417);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(75, 23);
            this.btn_menu.TabIndex = 64;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // hora
            // 
            this.hora.Enabled = true;
            this.hora.Tick += new System.EventHandler(this.hora_Tick);
            // 
            // FrmTutoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 678);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Name = "FrmTutoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTutoria";
            this.Load += new System.EventHandler(this.FrmTutoria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbox_asistencia.ResumeLayout(false);
            this.gbox_asistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txt_docente;
        private System.Windows.Forms.ComboBox cbdocente;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_ap;
        private System.Windows.Forms.TextBox txt_am;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.RichTextBox txt_tema;
        private System.Windows.Forms.GroupBox gbox_asistencia;
        private System.Windows.Forms.RadioButton rb_si;
        private System.Windows.Forms.RadioButton rb_no;
        private System.Windows.Forms.Label lb_asistencia;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Timer hora;
    }
}