namespace academico
{
    partial class DocenteAlumnos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_coddocente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_am = new System.Windows.Forms.TextBox();
            this.txt_ap = new System.Windows.Forms.TextBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_asignacion = new System.Windows.Forms.TextBox();
            this.btn_mover = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txt_materno = new System.Windows.Forms.TextBox();
            this.txt_paterno = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_coddocente = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(124, 181);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(800, 198);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cb_coddocente
            // 
            this.cb_coddocente.FormattingEnabled = true;
            this.cb_coddocente.Location = new System.Drawing.Point(471, 111);
            this.cb_coddocente.Name = "cb_coddocente";
            this.cb_coddocente.Size = new System.Drawing.Size(328, 24);
            this.cb_coddocente.TabIndex = 72;
            this.cb_coddocente.SelectedIndexChanged += new System.EventHandler(this.cb_coddocente_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(274, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 31);
            this.label3.TabIndex = 70;
            this.label3.Text = "DOCENTE";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(140, 6);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(215, 22);
            this.txt_codigo.TabIndex = 60;
            // 
            // txt_am
            // 
            this.txt_am.Location = new System.Drawing.Point(824, 6);
            this.txt_am.Margin = new System.Windows.Forms.Padding(4);
            this.txt_am.Name = "txt_am";
            this.txt_am.Size = new System.Drawing.Size(204, 22);
            this.txt_am.TabIndex = 57;
            // 
            // txt_ap
            // 
            this.txt_ap.Location = new System.Drawing.Point(612, 6);
            this.txt_ap.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ap.Name = "txt_ap";
            this.txt_ap.Size = new System.Drawing.Size(204, 22);
            this.txt_ap.TabIndex = 56;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(407, 6);
            this.txt_nombres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(197, 22);
            this.txt_nombres.TabIndex = 55;
            // 
            // txt_asignacion
            // 
            this.txt_asignacion.Location = new System.Drawing.Point(0, 6);
            this.txt_asignacion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_asignacion.Name = "txt_asignacion";
            this.txt_asignacion.Size = new System.Drawing.Size(132, 22);
            this.txt_asignacion.TabIndex = 54;
            // 
            // btn_mover
            // 
            this.btn_mover.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_mover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mover.Location = new System.Drawing.Point(291, 403);
            this.btn_mover.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mover.Name = "btn_mover";
            this.btn_mover.Size = new System.Drawing.Size(164, 44);
            this.btn_mover.TabIndex = 77;
            this.btn_mover.Text = "Mover";
            this.btn_mover.UseVisualStyleBackColor = false;
            this.btn_mover.Click += new System.EventHandler(this.btn_mover_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(510, 403);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(125, 44);
            this.btneliminar.TabIndex = 75;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txt_materno
            // 
            this.txt_materno.Location = new System.Drawing.Point(792, 36);
            this.txt_materno.Margin = new System.Windows.Forms.Padding(4);
            this.txt_materno.Name = "txt_materno";
            this.txt_materno.Size = new System.Drawing.Size(204, 22);
            this.txt_materno.TabIndex = 80;
            this.txt_materno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_paterno
            // 
            this.txt_paterno.Location = new System.Drawing.Point(587, 36);
            this.txt_paterno.Margin = new System.Windows.Forms.Padding(4);
            this.txt_paterno.Name = "txt_paterno";
            this.txt_paterno.Size = new System.Drawing.Size(197, 22);
            this.txt_paterno.TabIndex = 79;
            this.txt_paterno.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(447, 36);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(132, 22);
            this.txt_nombre.TabIndex = 78;
            this.txt_nombre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_coddocente
            // 
            this.txt_coddocente.Location = new System.Drawing.Point(291, 36);
            this.txt_coddocente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_coddocente.Name = "txt_coddocente";
            this.txt_coddocente.Size = new System.Drawing.Size(132, 22);
            this.txt_coddocente.TabIndex = 81;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(124, 36);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(132, 22);
            this.txt_correo.TabIndex = 82;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(58, 465);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(913, 205);
            this.dataGridView2.TabIndex = 83;
            // 
            // DocenteAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 920);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_coddocente);
            this.Controls.Add(this.txt_materno);
            this.Controls.Add(this.txt_paterno);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.btn_mover);
            this.Controls.Add(this.txt_am);
            this.Controls.Add(this.txt_ap);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.txt_asignacion);
            this.Controls.Add(this.cb_coddocente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DocenteAlumnos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DocenteAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_coddocente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_am;
        private System.Windows.Forms.TextBox txt_ap;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_asignacion;
        private System.Windows.Forms.Button btn_mover;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox txt_materno;
        private System.Windows.Forms.TextBox txt_paterno;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_coddocente;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}