namespace ProyectoGestionDeFeria
{
    partial class FParticipantes
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
            lbNombresP = new Label();
            lbEmprendimientoS = new Label();
            lbParticipantes = new Label();
            txtNombresP = new TextBox();
            txtApellidosP = new TextBox();
            lbApellidosP = new Label();
            lbCargoP = new Label();
            ContenedorArchivoC2 = new GroupBox();
            btnArchivo2 = new Button();
            lbFotoP = new Label();
            btnAgregarP = new Button();
            lbPartiR = new Label();
            dVParticipante = new DataGridView();
            cBoxSeleccionarERP = new ComboBox();
            cBoxCargo = new ComboBox();
            ContenedorArchivoC2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dVParticipante).BeginInit();
            SuspendLayout();
            // 
            // lbNombresP
            // 
            lbNombresP.AutoSize = true;
            lbNombresP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombresP.Location = new Point(96, 201);
            lbNombresP.Name = "lbNombresP";
            lbNombresP.Size = new Size(102, 25);
            lbNombresP.TabIndex = 23;
            lbNombresP.Text = "Nombres *";
            // 
            // lbEmprendimientoS
            // 
            lbEmprendimientoS.AutoSize = true;
            lbEmprendimientoS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmprendimientoS.Location = new Point(12, 102);
            lbEmprendimientoS.Name = "lbEmprendimientoS";
            lbEmprendimientoS.Size = new Size(268, 25);
            lbEmprendimientoS.TabIndex = 19;
            lbEmprendimientoS.Text = "Seleccionar Emprendimiento *";
            // 
            // lbParticipantes
            // 
            lbParticipantes.AutoSize = true;
            lbParticipantes.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbParticipantes.Location = new Point(3, 27);
            lbParticipantes.Name = "lbParticipantes";
            lbParticipantes.Size = new Size(448, 45);
            lbParticipantes.TabIndex = 17;
            lbParticipantes.Text = "👥 Registro de Participantes";
            // 
            // txtNombresP
            // 
            txtNombresP.Location = new Point(96, 229);
            txtNombresP.Name = "txtNombresP";
            txtNombresP.Size = new Size(296, 31);
            txtNombresP.TabIndex = 31;
            // 
            // txtApellidosP
            // 
            txtApellidosP.Location = new Point(682, 229);
            txtApellidosP.Name = "txtApellidosP";
            txtApellidosP.Size = new Size(296, 31);
            txtApellidosP.TabIndex = 33;
            // 
            // lbApellidosP
            // 
            lbApellidosP.AutoSize = true;
            lbApellidosP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbApellidosP.Location = new Point(682, 201);
            lbApellidosP.Name = "lbApellidosP";
            lbApellidosP.Size = new Size(104, 25);
            lbApellidosP.TabIndex = 32;
            lbApellidosP.Text = "Apellidos *";
            // 
            // lbCargoP
            // 
            lbCargoP.AutoSize = true;
            lbCargoP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCargoP.Location = new Point(96, 294);
            lbCargoP.Name = "lbCargoP";
            lbCargoP.Size = new Size(150, 25);
            lbCargoP.TabIndex = 34;
            lbCargoP.Text = "Cargo/Función *";
            // 
            // ContenedorArchivoC2
            // 
            ContenedorArchivoC2.Controls.Add(btnArchivo2);
            ContenedorArchivoC2.Location = new Point(682, 322);
            ContenedorArchivoC2.Name = "ContenedorArchivoC2";
            ContenedorArchivoC2.Size = new Size(326, 84);
            ContenedorArchivoC2.TabIndex = 37;
            ContenedorArchivoC2.TabStop = false;
            // 
            // btnArchivo2
            // 
            btnArchivo2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnArchivo2.Location = new Point(6, 30);
            btnArchivo2.Name = "btnArchivo2";
            btnArchivo2.Size = new Size(161, 34);
            btnArchivo2.TabIndex = 12;
            btnArchivo2.Text = "Seleccionar archivo";
            btnArchivo2.UseVisualStyleBackColor = true;
            btnArchivo2.Click += btnArchivo2_Click;
            // 
            // lbFotoP
            // 
            lbFotoP.AutoSize = true;
            lbFotoP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFotoP.Location = new Point(682, 294);
            lbFotoP.Name = "lbFotoP";
            lbFotoP.Size = new Size(140, 25);
            lbFotoP.TabIndex = 36;
            lbFotoP.Text = "Foto Individual";
            lbFotoP.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAgregarP
            // 
            btnAgregarP.Location = new Point(96, 434);
            btnAgregarP.Name = "btnAgregarP";
            btnAgregarP.Size = new Size(228, 34);
            btnAgregarP.TabIndex = 38;
            btnAgregarP.Text = "Agregar Participante";
            btnAgregarP.UseVisualStyleBackColor = true;
            btnAgregarP.Click += btnAgregarP_Click;
            // 
            // lbPartiR
            // 
            lbPartiR.AutoSize = true;
            lbPartiR.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPartiR.Location = new Point(22, 515);
            lbPartiR.Name = "lbPartiR";
            lbPartiR.Size = new Size(229, 25);
            lbPartiR.TabIndex = 39;
            lbPartiR.Text = "Participantes Registrados";
            // 
            // dVParticipante
            // 
            dVParticipante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dVParticipante.Location = new Point(12, 554);
            dVParticipante.Name = "dVParticipante";
            dVParticipante.RowHeadersWidth = 62;
            dVParticipante.Size = new Size(996, 279);
            dVParticipante.TabIndex = 40;
            // 
            // cBoxSeleccionarERP
            // 
            cBoxSeleccionarERP.FormattingEnabled = true;
            cBoxSeleccionarERP.Location = new Point(12, 139);
            cBoxSeleccionarERP.Name = "cBoxSeleccionarERP";
            cBoxSeleccionarERP.Size = new Size(996, 33);
            cBoxSeleccionarERP.TabIndex = 41;
            cBoxSeleccionarERP.SelectedIndexChanged += cBoxSeleccionarERP_SelectedIndexChanged;
            // 
            // cBoxCargo
            // 
            cBoxCargo.FormattingEnabled = true;
            cBoxCargo.Items.AddRange(new object[] { "Lider de Proyecto", "Diseñador", "Expositor", "Desarrollador", "Marketing" });
            cBoxCargo.Location = new Point(96, 353);
            cBoxCargo.Name = "cBoxCargo";
            cBoxCargo.Size = new Size(296, 33);
            cBoxCargo.TabIndex = 42;
            // 
            // FParticipantes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 845);
            Controls.Add(cBoxCargo);
            Controls.Add(cBoxSeleccionarERP);
            Controls.Add(dVParticipante);
            Controls.Add(lbPartiR);
            Controls.Add(btnAgregarP);
            Controls.Add(ContenedorArchivoC2);
            Controls.Add(lbFotoP);
            Controls.Add(lbCargoP);
            Controls.Add(txtApellidosP);
            Controls.Add(lbApellidosP);
            Controls.Add(txtNombresP);
            Controls.Add(lbNombresP);
            Controls.Add(lbEmprendimientoS);
            Controls.Add(lbParticipantes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FParticipantes";
            Text = "FParticipantes";
            ContenedorArchivoC2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dVParticipante).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbNombresP;
        private Label lbEmprendimientoS;
        private Label lbParticipantes;
        private TextBox txtNombresP;
        private TextBox txtApellidosP;
        private Label lbApellidosP;
        private Label lbCargoP;
        private GroupBox ContenedorArchivoC2;
        private Button btnArchivo2;
        private Label lbFotoP;
        private Button btnAgregarP;
        private Label lbPartiR;
        private DataGridView dVParticipante;
        private ComboBox cBoxSeleccionarERP;
        private ComboBox cBoxCargo;
    }
}