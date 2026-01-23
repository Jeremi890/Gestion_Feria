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
            btnRegistrarEmprendimiento = new Button();
            btnParticipantes = new Button();
            btnGestionEventos = new Button();
            btnResultados = new Button();
            PanelDesarrollo = new Panel();
            SuspendLayout();
            // 
            // btnRegistrarEmprendimiento
            // 
            btnRegistrarEmprendimiento.Location = new Point(12, 23);
            btnRegistrarEmprendimiento.Name = "btnRegistrarEmprendimiento";
            btnRegistrarEmprendimiento.Size = new Size(242, 64);
            btnRegistrarEmprendimiento.TabIndex = 0;
            btnRegistrarEmprendimiento.Text = "Registrar Emprendimiento";
            btnRegistrarEmprendimiento.UseVisualStyleBackColor = true;
            btnRegistrarEmprendimiento.Click += btnRegistrarEmprendimiento_Click;
            // 
            // btnParticipantes
            // 
            btnParticipantes.Location = new Point(347, 23);
            btnParticipantes.Name = "btnParticipantes";
            btnParticipantes.Size = new Size(242, 64);
            btnParticipantes.TabIndex = 1;
            btnParticipantes.Text = "Participantes";
            btnParticipantes.UseVisualStyleBackColor = true;
            btnParticipantes.Click += btnParticipantes_Click;
            // 
            // btnGestionEventos
            // 
            btnGestionEventos.Location = new Point(675, 23);
            btnGestionEventos.Name = "btnGestionEventos";
            btnGestionEventos.Size = new Size(242, 64);
            btnGestionEventos.TabIndex = 2;
            btnGestionEventos.Text = "Gestión de Eventos";
            btnGestionEventos.UseVisualStyleBackColor = true;
            btnGestionEventos.Click += btnGestionEventos_Click;
            // 
            // btnResultados
            // 
            btnResultados.Location = new Point(1002, 23);
            btnResultados.Name = "btnResultados";
            btnResultados.Size = new Size(242, 64);
            btnResultados.TabIndex = 3;
            btnResultados.Text = "Resultados";
            btnResultados.UseVisualStyleBackColor = true;
            btnResultados.Click += btnResultados_Click;
            // 
            // PanelDesarrollo
            // 
            PanelDesarrollo.AutoScroll = true;
            PanelDesarrollo.BackColor = SystemColors.ActiveCaption;
            PanelDesarrollo.Location = new Point(12, 106);
            PanelDesarrollo.Name = "PanelDesarrollo";
            PanelDesarrollo.Size = new Size(1232, 908);
            PanelDesarrollo.TabIndex = 4;
            // 
            // FEventosAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 1026);
            Controls.Add(PanelDesarrollo);
            Controls.Add(btnResultados);
            Controls.Add(btnGestionEventos);
            Controls.Add(btnParticipantes);
            Controls.Add(btnRegistrarEmprendimiento);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FEventosAdmin";
            Text = "FEventosAdmin";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarEmprendimiento;
        private Button btnParticipantes;
        private Button btnGestionEventos;
        private Button btnResultados;
        private Panel PanelDesarrollo;
    }
}