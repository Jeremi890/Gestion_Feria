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
            panelizquierdo = new Panel();
            panelizquierdo.SuspendLayout();
            SuspendLayout();
            // 
            // btnConsultarEmprendimientos
            // 
            btnConsultarEmprendimientos.AutoSize = true;
            btnConsultarEmprendimientos.BackColor = Color.FromArgb(0, 64, 64);
            btnConsultarEmprendimientos.Cursor = Cursors.Hand;
            btnConsultarEmprendimientos.FlatStyle = FlatStyle.Flat;
            btnConsultarEmprendimientos.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultarEmprendimientos.ForeColor = SystemColors.ButtonHighlight;
            btnConsultarEmprendimientos.Location = new Point(22, 55);
            btnConsultarEmprendimientos.Margin = new Padding(0);
            btnConsultarEmprendimientos.Name = "btnConsultarEmprendimientos";
            btnConsultarEmprendimientos.Size = new Size(192, 48);
            btnConsultarEmprendimientos.TabIndex = 0;
            btnConsultarEmprendimientos.Text = " ";
            btnConsultarEmprendimientos.TextAlign = ContentAlignment.MiddleRight;
            btnConsultarEmprendimientos.UseVisualStyleBackColor = false;
            btnConsultarEmprendimientos.Click += btnConsultarEmprendimientos_Click;
            // 
            // btnCalendario2
            // 
            btnCalendario2.AutoSize = true;
            btnCalendario2.BackColor = Color.FromArgb(0, 64, 64);
            btnCalendario2.Cursor = Cursors.Hand;
            btnCalendario2.FlatStyle = FlatStyle.Flat;
            btnCalendario2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalendario2.ForeColor = SystemColors.ButtonHighlight;
            btnCalendario2.Location = new Point(22, 113);
            btnCalendario2.Margin = new Padding(0);
            btnCalendario2.Name = "btnCalendario2";
            btnCalendario2.Size = new Size(192, 48);
            btnCalendario2.TabIndex = 1;
            btnCalendario2.Text = "CALENDARIO";
            btnCalendario2.TextAlign = ContentAlignment.MiddleRight;
            btnCalendario2.UseVisualStyleBackColor = false;
            btnCalendario2.Click += btnCalendario2_Click;
            // 
            // btnGaleria
            // 
            btnGaleria.AutoSize = true;
            btnGaleria.BackColor = Color.FromArgb(0, 64, 64);
            btnGaleria.Cursor = Cursors.Hand;
            btnGaleria.FlatStyle = FlatStyle.Flat;
            btnGaleria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGaleria.ForeColor = SystemColors.ButtonHighlight;
            btnGaleria.Location = new Point(22, 171);
            btnGaleria.Margin = new Padding(0);
            btnGaleria.Name = "btnGaleria";
            btnGaleria.Size = new Size(192, 48);
            btnGaleria.TabIndex = 3;
            btnGaleria.Text = "GALERIA";
            btnGaleria.TextAlign = ContentAlignment.MiddleRight;
            btnGaleria.UseVisualStyleBackColor = false;
            btnGaleria.Click += btnGaleria_Click;
            // 
            // btnVotacion
            // 
            btnVotacion.AutoSize = true;
            btnVotacion.BackColor = Color.FromArgb(0, 64, 64);
            btnVotacion.Cursor = Cursors.Hand;
            btnVotacion.FlatAppearance.BorderSize = 0;
            btnVotacion.FlatStyle = FlatStyle.Flat;
            btnVotacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVotacion.ForeColor = SystemColors.ButtonHighlight;
            btnVotacion.Location = new Point(22, 230);
            btnVotacion.Margin = new Padding(0);
            btnVotacion.Name = "btnVotacion";
            btnVotacion.Size = new Size(192, 48);
            btnVotacion.TabIndex = 3;
            btnVotacion.Text = "VOTACION";
            btnVotacion.TextAlign = ContentAlignment.MiddleRight;
            btnVotacion.UseVisualStyleBackColor = false;
            btnVotacion.Click += btnVotacion_Click;
            // 
            // panelModuloEstudiante
            // 
            panelModuloEstudiante.BackColor = Color.SteelBlue;
            panelModuloEstudiante.BorderStyle = BorderStyle.FixedSingle;
            panelModuloEstudiante.Dock = DockStyle.Fill;
            panelModuloEstudiante.Location = new Point(214, 0);
            panelModuloEstudiante.Margin = new Padding(2);
            panelModuloEstudiante.Name = "panelModuloEstudiante";
            panelModuloEstudiante.Size = new Size(665, 473);
            panelModuloEstudiante.TabIndex = 4;
            // 
            // panelizquierdo
            // 
            panelizquierdo.BackColor = Color.Lavender;
            panelizquierdo.Controls.Add(btnConsultarEmprendimientos);
            panelizquierdo.Controls.Add(btnVotacion);
            panelizquierdo.Controls.Add(btnCalendario2);
            panelizquierdo.Controls.Add(btnGaleria);
            panelizquierdo.Dock = DockStyle.Left;
            panelizquierdo.ForeColor = SystemColors.ActiveCaptionText;
            panelizquierdo.Location = new Point(0, 0);
            panelizquierdo.Name = "panelizquierdo";
            panelizquierdo.Size = new Size(214, 473);
            panelizquierdo.TabIndex = 5;
            panelizquierdo.Paint += panelizquierdo_Paint;
            // 
            // FModuloEstudiante
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(879, 473);
            Controls.Add(panelModuloEstudiante);
            Controls.Add(panelizquierdo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FModuloEstudiante";
            Text = "FModuloEstudiante";
            Load += FModuloEstudiante_Load;
            panelizquierdo.ResumeLayout(false);
            panelizquierdo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConsultarEmprendimientos;
        private Button btnCalendario2;
        private Button btnGaleria;
        private Button btnVotacion;
        private Panel panelModuloEstudiante;
        private Panel panelizquierdo;
    }
}