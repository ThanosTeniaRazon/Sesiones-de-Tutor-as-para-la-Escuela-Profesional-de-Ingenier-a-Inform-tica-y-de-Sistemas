namespace academico
{
    partial class FrmMenu
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
            this.btn_alumnos = new System.Windows.Forms.Button();
            this.btn_docentes = new System.Windows.Forms.Button();
            this.btn_tutoria = new System.Windows.Forms.Button();
            this.btn_asignacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_alumnos
            // 
            this.btn_alumnos.Location = new System.Drawing.Point(0, 2);
            this.btn_alumnos.Name = "btn_alumnos";
            this.btn_alumnos.Size = new System.Drawing.Size(345, 271);
            this.btn_alumnos.TabIndex = 1;
            this.btn_alumnos.Text = "Alumnos";
            this.btn_alumnos.UseVisualStyleBackColor = true;
            this.btn_alumnos.Click += new System.EventHandler(this.btn_alumnos_Click);
            // 
            // btn_docentes
            // 
            this.btn_docentes.Location = new System.Drawing.Point(342, 2);
            this.btn_docentes.Name = "btn_docentes";
            this.btn_docentes.Size = new System.Drawing.Size(345, 271);
            this.btn_docentes.TabIndex = 2;
            this.btn_docentes.Text = "Docentes";
            this.btn_docentes.UseVisualStyleBackColor = true;
            this.btn_docentes.Click += new System.EventHandler(this.btn_docentes_Click);
            // 
            // btn_tutoria
            // 
            this.btn_tutoria.Location = new System.Drawing.Point(342, 273);
            this.btn_tutoria.Name = "btn_tutoria";
            this.btn_tutoria.Size = new System.Drawing.Size(345, 271);
            this.btn_tutoria.TabIndex = 4;
            this.btn_tutoria.Text = "Tutoria";
            this.btn_tutoria.UseVisualStyleBackColor = true;
            this.btn_tutoria.Click += new System.EventHandler(this.btn_tutoria_Click);
            // 
            // btn_asignacion
            // 
            this.btn_asignacion.Location = new System.Drawing.Point(0, 273);
            this.btn_asignacion.Name = "btn_asignacion";
            this.btn_asignacion.Size = new System.Drawing.Size(345, 271);
            this.btn_asignacion.TabIndex = 3;
            this.btn_asignacion.Text = "Asignación";
            this.btn_asignacion.UseVisualStyleBackColor = true;
            this.btn_asignacion.Click += new System.EventHandler(this.btn_asignacion_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(686, 546);
            this.Controls.Add(this.btn_tutoria);
            this.Controls.Add(this.btn_asignacion);
            this.Controls.Add(this.btn_docentes);
            this.Controls.Add(this.btn_alumnos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_alumnos;
        private System.Windows.Forms.Button btn_docentes;
        private System.Windows.Forms.Button btn_tutoria;
        private System.Windows.Forms.Button btn_asignacion;
    }
}