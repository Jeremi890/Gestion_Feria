namespace ProyectoGestionDeFeria
{
    partial class FModuloEstudiante
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
            btnConsultarEmprendimientos = new Button();
            btnCalendario2 = new Button();
            btnGaleria = new Button();
            btnVotacion = new Button();
            panelModuloEstudiante = new Panel();
            SuspendLayout();
            // 
            // btnConsultarEmprendimientos
            // 
            btnConsultarEmprendimientos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultarEmprendimientos.Location = new Point(12, 32);
            btnConsultarEmprendimientos.Name = "btnConsultarEmprendimientos";
            btnConsultarEmprendimientos.Size = new Size(272, 34);
            btnConsultarEmprendimientos.TabIndex = 0;
            btnConsultarEmprendimientos.Text = "Consultar Emprendimientos";
            btnConsultarEmprendimientos.UseVisualStyleBackColor = true;
            btnConsultarEmprendimientos.Click += btnConsultarEmprendimientos_Click;
            // 
            // btnCalendario2
            // 
            btnCalendario2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalendario2.Location = new Point(350, 32);
            btnCalendario2.Name = "btnCalendario2";
            btnCalendario2.Size = new Size(112, 34);
            btnCalendario2.TabIndex = 1;
            btnCalendario2.Text = "Calendario";
            btnCalendario2.UseVisualStyleBackColor = true;
            btnCalendario2.Click += btnCalendario2_Click;
            // 
            // btnGaleria
            // 
            btnGaleria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGaleria.Location = new Point(530, 32);
            btnGaleria.Name = "btnGaleria";
            btnGaleria.Size = new Size(112, 34);
            btnGaleria.TabIndex = 2;
            btnGaleria.Text = "Galeria";
            btnGaleria.UseVisualStyleBackColor = true;
            btnGaleria.Click += btnGaleria_Click;
            // 
            // btnVotacion
            // 
            btnVotacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVotacion.Location = new Point(707, 32);
            btnVotacion.Name = "btnVotacion";
            btnVotacion.Size = new Size(112, 34);
            btnVotacion.TabIndex = 3;
            btnVotacion.Text = "Votacion";
            btnVotacion.UseVisualStyleBackColor = true;
            btnVotacion.Click += btnVotacion_Click;
            // 
            // panelModuloEstudiante
            // 
            panelModuloEstudiante.BackColor = SystemColors.ActiveCaption;
            panelModuloEstudiante.Location = new Point(12, 92);
            panelModuloEstudiante.Name = "panelModuloEstudiante";
            panelModuloEstudiante.Size = new Size(807, 551);
            panelModuloEstudiante.TabIndex = 4;
            // 
            // FModuloEstudiante
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 655);
            Controls.Add(panelModuloEstudiante);
            Controls.Add(btnVotacion);
            Controls.Add(btnGaleria);
            Controls.Add(btnCalendario2);
            Controls.Add(btnConsultarEmprendimientos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FModuloEstudiante";
            Text = "FModuloEstudiante";
            ResumeLayout(false);
        }

        #endregion

        private Button btnConsultarEmprendimientos;
        private Button btnCalendario2;
        private Button btnGaleria;
        private Button btnVotacion;
        private Panel panelModuloEstudiante;
    }
}