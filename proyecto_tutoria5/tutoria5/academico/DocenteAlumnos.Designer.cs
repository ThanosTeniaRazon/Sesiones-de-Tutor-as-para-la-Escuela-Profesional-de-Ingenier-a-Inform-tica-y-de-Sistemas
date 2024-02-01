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
            this.txt_coddocente = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.btn_mover = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_ii_asignacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 183);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(589, 665);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cb_coddocente
            // 
            this.cb_coddocente.FormattingEnabled = true;
            this.cb_coddocente.Location = new System.Drawing.Point(401, 72);
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
            this.label3.Location = new System.Drawing.Point(475, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 31);
            this.label3.TabIndex = 70;
            this.label3.Text = "DOCENTE";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(13, 13);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(197, 22);
            this.txt_codigo.TabIndex = 60;
            // 
            // txt_am
            // 
            this.txt_am.Location = new System.Drawing.Point(13, 104);
            this.txt_am.Margin = new System.Windows.Forms.Padding(4);
            this.txt_am.Name = "txt_am";
            this.txt_am.Size = new System.Drawing.Size(204, 22);
            this.txt_am.TabIndex = 57;
            // 
            // txt_ap
            // 
            this.txt_ap.Location = new System.Drawing.Point(13, 74);
            this.txt_ap.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ap.Name = "txt_ap";
            this.txt_ap.Size = new System.Drawing.Size(204, 22);
            this.txt_ap.TabIndex = 56;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(13, 43);
            this.txt_nombres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(197, 22);
            this.txt_nombres.TabIndex = 55;
            // 
            // txt_coddocente
            // 
            this.txt_coddocente.Location = new System.Drawing.Point(401, 103);
            this.txt_coddocente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_coddocente.Name = "txt_coddocente";
            this.txt_coddocente.Size = new System.Drawing.Size(328, 22);
            this.txt_coddocente.TabIndex = 81;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(13, 134);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(204, 22);
            this.txt_correo.TabIndex = 82;
            // 
            // btn_mover
            // 
            this.btn_mover.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_mover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mover.Image = global::academico.Properties.Resources.down__4_;
            this.btn_mover.Location = new System.Drawing.Point(787, 74);
            this.btn_mover.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mover.Name = "btn_mover";
            this.btn_mover.Size = new System.Drawing.Size(75, 59);
            this.btn_mover.TabIndex = 77;
            this.btn_mover.UseVisualStyleBackColor = false;
            this.btn_mover.Click += new System.EventHandler(this.btn_mover_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Image = global::academico.Properties.Resources.up_arrow;
            this.btneliminar.Location = new System.Drawing.Point(883, 74);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(89, 60);
            this.btneliminar.TabIndex = 75;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.Location = new System.Drawing.Point(991, 74);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(111, 52);
            this.btn_menu.TabIndex = 85;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(610, 183);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(872, 665);
            this.dataGridView2.TabIndex = 86;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick_1);
            // 
            // txt_ii_asignacion
            // 
            this.txt_ii_asignacion.Location = new System.Drawing.Point(218, 13);
            this.txt_ii_asignacion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ii_asignacion.Name = "txt_ii_asignacion";
            this.txt_ii_asignacion.Size = new System.Drawing.Size(197, 22);
            this.txt_ii_asignacion.TabIndex = 87;
            // 
            // DocenteAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 920);
            this.Controls.Add(this.txt_ii_asignacion);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_coddocente);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.btn_mover);
            this.Controls.Add(this.txt_am);
            this.Controls.Add(this.txt_ap);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.cb_coddocente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DocenteAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DocenteAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_am;
        private System.Windows.Forms.TextBox txt_ap;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.Button btn_mover;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox txt_coddocente;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Button btn_menu;
        public System.Windows.Forms.ComboBox cb_coddocente;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txt_ii_asignacion;
    }
}