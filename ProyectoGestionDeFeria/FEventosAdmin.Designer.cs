namespace ProyectoGestionDeFeria
{
    partial class FEventosAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEventosAdmin));
            btnRegistrarEmprendimiento = new Button();
            btnParticipantes = new Button();
            btnGestionEventos = new Button();
            btnResultados = new Button();
            PanelDesarrollo = new Panel();
            panelizquierdoAdmin = new Panel();
            button1 = new Button();
            PanelDesarrollo1 = new Panel();
            panelizquierdoAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrarEmprendimiento
            // 
            btnRegistrarEmprendimiento.BackColor = Color.FromArgb(0, 64, 64);
            btnRegistrarEmprendimiento.Cursor = Cursors.Hand;
            btnRegistrarEmprendimiento.FlatStyle = FlatStyle.Flat;
            btnRegistrarEmprendimiento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarEmprendimiento.ForeColor = SystemColors.ButtonFace;
            btnRegistrarEmprendimiento.Location = new Point(22, 152);
            btnRegistrarEmprendimiento.Margin = new Padding(0);
            btnRegistrarEmprendimiento.Name = "btnRegistrarEmprendimiento";
            btnRegistrarEmprendimiento.Size = new Size(192, 48);
            btnRegistrarEmprendimiento.TabIndex = 0;
            btnRegistrarEmprendimiento.Text = "REGISTRAR EMPRENDIMIENTO";
            btnRegistrarEmprendimiento.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarEmprendimiento.UseVisualStyleBackColor = false;
            btnRegistrarEmprendimiento.Click += btnRegistrarEmprendimiento_Click;
            // 
            // btnParticipantes
            // 
            btnParticipantes.BackColor = Color.FromArgb(0, 64, 64);
            btnParticipantes.Cursor = Cursors.Hand;
            btnParticipantes.FlatStyle = FlatStyle.Flat;
            btnParticipantes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnParticipantes.ForeColor = SystemColors.ControlLightLight;
            btnParticipantes.Location = new Point(22, 210);
            btnParticipantes.Margin = new Padding(2);
            btnParticipantes.Name = "btnParticipantes";
            btnParticipantes.Size = new Size(192, 48);
            btnParticipantes.TabIndex = 1;
            btnParticipantes.Text = "PARTICIPANTES";
            btnParticipantes.TextAlign = ContentAlignment.MiddleRight;
            btnParticipantes.UseVisualStyleBackColor = false;
            btnParticipantes.Click += btnParticipantes_Click;
            // 
            // btnGestionEventos
            // 
            btnGestionEventos.BackColor = Color.FromArgb(0, 64, 64);
            btnGestionEventos.Cursor = Cursors.Hand;
            btnGestionEventos.FlatStyle = FlatStyle.Flat;
            btnGestionEventos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionEventos.ForeColor = SystemColors.ControlLightLight;
            btnGestionEventos.Location = new Point(22, 268);
            btnGestionEventos.Margin = new Padding(2);
            btnGestionEventos.Name = "btnGestionEventos";
            btnGestionEventos.Size = new Size(192, 48);
            btnGestionEventos.TabIndex = 2;
            btnGestionEventos.Text = "GESTIÓN DE EVENTO";
            btnGestionEventos.TextAlign = ContentAlignment.MiddleRight;
            btnGestionEventos.UseVisualStyleBackColor = false;
            btnGestionEventos.Click += btnGestionEventos_Click;
            // 
            // btnResultados
            // 
            btnResultados.BackColor = Color.FromArgb(0, 64, 64);
            btnResultados.Cursor = Cursors.Hand;
            btnResultados.FlatStyle = FlatStyle.Flat;
            btnResultados.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResultados.ForeColor = SystemColors.ControlLightLight;
            btnResultados.Location = new Point(22, 327);
            btnResultados.Margin = new Padding(2);
            btnResultados.Name = "btnResultados";
            btnResultados.Size = new Size(192, 48);
            btnResultados.TabIndex = 3;
            btnResultados.Text = "RESULTADOS";
            btnResultados.TextAlign = ContentAlignment.MiddleRight;
            btnResultados.UseVisualStyleBackColor = false;
            btnResultados.Click += btnResultados_Click;
            // 
            // PanelDesarrollo
            // 
            PanelDesarrollo.AutoScroll = true;
            PanelDesarrollo.AutoSize = true;
            PanelDesarrollo.BackColor = SystemColors.ActiveCaption;
            PanelDesarrollo.Location = new Point(214, 0);
            PanelDesarrollo.Margin = new Padding(2);
            PanelDesarrollo.Name = "PanelDesarrollo";
            PanelDesarrollo.Size = new Size(665, 473);
            PanelDesarrollo.TabIndex = 4;
            // 
            // panelizquierdoAdmin
            // 
            panelizquierdoAdmin.Controls.Add(button1);
            panelizquierdoAdmin.Controls.Add(btnResultados);
            panelizquierdoAdmin.Controls.Add(btnRegistrarEmprendimiento);
            panelizquierdoAdmin.Controls.Add(PanelDesarrollo);
            panelizquierdoAdmin.Controls.Add(btnGestionEventos);
            panelizquierdoAdmin.Controls.Add(btnParticipantes);
            panelizquierdoAdmin.Dock = DockStyle.Left;
            panelizquierdoAdmin.Location = new Point(0, 0);
            panelizquierdoAdmin.Name = "panelizquierdoAdmin";
            panelizquierdoAdmin.Size = new Size(214, 473);
            panelizquierdoAdmin.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(51, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(125, 153);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            // 
            // PanelDesarrollo1
            // 
            PanelDesarrollo1.AutoSize = true;
            PanelDesarrollo1.Dock = DockStyle.Fill;
            PanelDesarrollo1.Location = new Point(214, 0);
            PanelDesarrollo1.Name = "PanelDesarrollo1";
            PanelDesarrollo1.Size = new Size(665, 473);
            PanelDesarrollo1.TabIndex = 6;
            PanelDesarrollo1.Paint += AbrirFormularioEnPanel_Paint;
            // 
            // FEventosAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(879, 473);
            Controls.Add(PanelDesarrollo1);
            Controls.Add(panelizquierdoAdmin);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FEventosAdmin";
            Text = "FEventosAdmin";
            Load += FEventosAdmin_Load;
            panelizquierdoAdmin.ResumeLayout(false);
            panelizquierdoAdmin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarEmprendimiento;
        private Button btnParticipantes;
        private Button btnGestionEventos;
        private Button btnResultados;
        private Panel PanelDesarrollo;
        private Panel panelizquierdoAdmin;
        private Panel PanelDesarrollo1;
        private Button button1;
    }
}