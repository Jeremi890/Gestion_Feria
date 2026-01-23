namespace ProyectoGestionDeFeria
{
    partial class FModuloAdministrador
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
            lbInformacion = new Label();
            labelEmprendimiento = new Label();
            lbNombreE = new Label();
            txtNombreE = new TextBox();
            lbFacultad = new Label();
            lbFoto = new Label();
            lbRubro = new Label();
            btnArchivo = new Button();
            ContenedorArchivoC1 = new GroupBox();
            lbDescripcion = new Label();
            txtDescripcion1 = new TextBox();
            btnGuardar1 = new Button();
            cBoxFacultadEmprendimiento = new ComboBox();
            cBoxRubro = new ComboBox();
            ContenedorArchivoC1.SuspendLayout();
            SuspendLayout();
            // 
            // lbInformacion
            // 
            lbInformacion.AutoSize = true;
            lbInformacion.BackColor = SystemColors.GradientInactiveCaption;
            lbInformacion.FlatStyle = FlatStyle.Flat;
            lbInformacion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbInformacion.Location = new Point(12, 77);
            lbInformacion.Name = "lbInformacion";
            lbInformacion.Size = new Size(753, 25);
            lbInformacion.TabIndex = 1;
            lbInformacion.Text = "Información: Complete el formulario para registrar un nuevo emprendimiento en la feria.";
            // 
            // labelEmprendimiento
            // 
            labelEmprendimiento.AutoSize = true;
            labelEmprendimiento.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmprendimiento.Location = new Point(12, 20);
            labelEmprendimiento.Name = "labelEmprendimiento";
            labelEmprendimiento.Size = new Size(518, 45);
            labelEmprendimiento.TabIndex = 0;
            labelEmprendimiento.Text = "📝 Registro de Emprendimientos";
            // 
            // lbNombreE
            // 
            lbNombreE.AutoSize = true;
            lbNombreE.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombreE.Location = new Point(21, 125);
            lbNombreE.Name = "lbNombreE";
            lbNombreE.Size = new Size(258, 25);
            lbNombreE.TabIndex = 5;
            lbNombreE.Text = "Nombre del Emprendimiento";
            // 
            // txtNombreE
            // 
            txtNombreE.Location = new Point(21, 163);
            txtNombreE.Name = "txtNombreE";
            txtNombreE.Size = new Size(366, 31);
            txtNombreE.TabIndex = 6;
            // 
            // lbFacultad
            // 
            lbFacultad.AutoSize = true;
            lbFacultad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFacultad.Location = new Point(499, 125);
            lbFacultad.Name = "lbFacultad";
            lbFacultad.Size = new Size(83, 25);
            lbFacultad.TabIndex = 7;
            lbFacultad.Text = "Facultad";
            // 
            // lbFoto
            // 
            lbFoto.AutoSize = true;
            lbFoto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFoto.Location = new Point(499, 239);
            lbFoto.Name = "lbFoto";
            lbFoto.Size = new Size(277, 25);
            lbFoto.TabIndex = 10;
            lbFoto.Text = "Logo/Foto del Emprendimiento";
            // 
            // lbRubro
            // 
            lbRubro.AutoSize = true;
            lbRubro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRubro.Location = new Point(21, 239);
            lbRubro.Name = "lbRubro";
            lbRubro.Size = new Size(69, 25);
            lbRubro.TabIndex = 9;
            lbRubro.Text = "Rubro:";
            // 
            // btnArchivo
            // 
            btnArchivo.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnArchivo.Location = new Point(6, 30);
            btnArchivo.Name = "btnArchivo";
            btnArchivo.Size = new Size(161, 34);
            btnArchivo.TabIndex = 12;
            btnArchivo.Text = "Seleccionar archivo";
            btnArchivo.UseVisualStyleBackColor = true;
            btnArchivo.Click += btnArchivo_Click;
            // 
            // ContenedorArchivoC1
            // 
            ContenedorArchivoC1.Controls.Add(btnArchivo);
            ContenedorArchivoC1.Location = new Point(499, 267);
            ContenedorArchivoC1.Name = "ContenedorArchivoC1";
            ContenedorArchivoC1.Size = new Size(326, 84);
            ContenedorArchivoC1.TabIndex = 13;
            ContenedorArchivoC1.TabStop = false;
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDescripcion.Location = new Point(21, 367);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(164, 25);
            lbDescripcion.TabIndex = 14;
            lbDescripcion.Text = "Descripción breve";
            // 
            // txtDescripcion1
            // 
            txtDescripcion1.Location = new Point(12, 395);
            txtDescripcion1.Multiline = true;
            txtDescripcion1.Name = "txtDescripcion1";
            txtDescripcion1.Size = new Size(813, 167);
            txtDescripcion1.TabIndex = 15;
            // 
            // btnGuardar1
            // 
            btnGuardar1.Location = new Point(45, 595);
            btnGuardar1.Name = "btnGuardar1";
            btnGuardar1.Size = new Size(178, 34);
            btnGuardar1.TabIndex = 16;
            btnGuardar1.Text = "Guardar Registro";
            btnGuardar1.UseVisualStyleBackColor = true;
            btnGuardar1.Click += btnGuardar1_Click;
            // 
            // cBoxFacultadEmprendimiento
            // 
            cBoxFacultadEmprendimiento.FormattingEnabled = true;
            cBoxFacultadEmprendimiento.Items.AddRange(new object[] { "ADMINISTRACION CENTRAL", "ARQUITECTURA Y URBANISMO", "CIENCIAS ADMINISTRATIVAS", "CIENCIAS AGRARIAS", "CIENCIAS DE LA ACTIVIDAD FÍSICA", "CIENCIAS ECONÓMICAS", "CIENCIAS MATEMÁTICAS Y FÍSICAS" });
            cBoxFacultadEmprendimiento.Location = new Point(499, 163);
            cBoxFacultadEmprendimiento.Name = "cBoxFacultadEmprendimiento";
            cBoxFacultadEmprendimiento.Size = new Size(326, 33);
            cBoxFacultadEmprendimiento.TabIndex = 17;
            // 
            // cBoxRubro
            // 
            cBoxRubro.FormattingEnabled = true;
            cBoxRubro.Items.AddRange(new object[] { "TECNOLOGÍA", "GASTRONOMÍA", "TEXTIL", "SERVICIOS", "SALUD" });
            cBoxRubro.Location = new Point(21, 288);
            cBoxRubro.Name = "cBoxRubro";
            cBoxRubro.Size = new Size(366, 33);
            cBoxRubro.TabIndex = 18;
            // 
            // FModuloAdministrador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 648);
            Controls.Add(cBoxRubro);
            Controls.Add(cBoxFacultadEmprendimiento);
            Controls.Add(btnGuardar1);
            Controls.Add(txtDescripcion1);
            Controls.Add(lbDescripcion);
            Controls.Add(ContenedorArchivoC1);
            Controls.Add(lbFoto);
            Controls.Add(lbRubro);
            Controls.Add(lbFacultad);
            Controls.Add(txtNombreE);
            Controls.Add(lbNombreE);
            Controls.Add(lbInformacion);
            Controls.Add(labelEmprendimiento);
            Name = "FModuloAdministrador";
            Text = "FModuloAdministrador";
            ContenedorArchivoC1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbInformacion;
        private Label labelEmprendimiento;
        private Label lbNombreE;
        private TextBox txtNombreE;
        private Label lbFacultad;
        private Label lbFoto;
        private Label lbRubro;
        private Button btnArchivo;
        private GroupBox ContenedorArchivoC1;
        private Label lbDescripcion;
        private TextBox txtDescripcion1;
        private Button btnGuardar1;
        private ComboBox cBoxFacultadEmprendimiento;
        private ComboBox cBoxRubro;
    }
}