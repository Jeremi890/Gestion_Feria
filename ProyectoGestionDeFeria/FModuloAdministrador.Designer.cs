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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FModuloAdministrador));
            lbInformacion = new Label();
            labelEmprendimiento = new Label();
            lbNombreE = new Label();
            txtNombreE = new TextBox();
            lbFacultad = new Label();
            lbFoto = new Label();
            lbRubro = new Label();
            btnArchivo = new Button();
            ContenedorArchivoC1 = new GroupBox();
            label1 = new Label();
            lbDescripcion = new Label();
            txtDescripcion1 = new TextBox();
            btnGuardar1 = new Button();
            cBoxFacultadEmprendimiento = new ComboBox();
            cBoxRubro = new ComboBox();
            panel1 = new Panel();
            panelRegistroEmp = new Panel();
            pictureBox1 = new PictureBox();
            ContenedorArchivoC1.SuspendLayout();
            panel1.SuspendLayout();
            panelRegistroEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbInformacion
            // 
            lbInformacion.AutoSize = true;
            lbInformacion.BackColor = Color.Transparent;
            lbInformacion.FlatStyle = FlatStyle.Flat;
            lbInformacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbInformacion.ForeColor = SystemColors.ControlLightLight;
            lbInformacion.Location = new Point(111, 62);
            lbInformacion.Margin = new Padding(2, 0, 2, 0);
            lbInformacion.Name = "lbInformacion";
            lbInformacion.Size = new Size(561, 17);
            lbInformacion.TabIndex = 1;
            lbInformacion.Text = "Información: Complete el formulario para registrar un nuevo emprendimiento en la feria.";
            // 
            // labelEmprendimiento
            // 
            labelEmprendimiento.AutoSize = true;
            labelEmprendimiento.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmprendimiento.ForeColor = SystemColors.ControlLightLight;
            labelEmprendimiento.Location = new Point(166, 20);
            labelEmprendimiento.Margin = new Padding(2, 0, 2, 0);
            labelEmprendimiento.Name = "labelEmprendimiento";
            labelEmprendimiento.Size = new Size(333, 30);
            labelEmprendimiento.TabIndex = 0;
            labelEmprendimiento.Text = "REGISTRO EMPRENDIMIENTOS";
            // 
            // lbNombreE
            // 
            lbNombreE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbNombreE.AutoSize = true;
            lbNombreE.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombreE.Location = new Point(13, 8);
            lbNombreE.Margin = new Padding(2, 0, 2, 0);
            lbNombreE.Name = "lbNombreE";
            lbNombreE.Size = new Size(191, 15);
            lbNombreE.TabIndex = 5;
            lbNombreE.Text = "NOMBRE DEL EMPRENDIMIENTO";
            // 
            // txtNombreE
            // 
            txtNombreE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreE.Location = new Point(13, 34);
            txtNombreE.Margin = new Padding(2);
            txtNombreE.Name = "txtNombreE";
            txtNombreE.Size = new Size(622, 23);
            txtNombreE.TabIndex = 6;
            // 
            // lbFacultad
            // 
            lbFacultad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbFacultad.AutoSize = true;
            lbFacultad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFacultad.Location = new Point(386, 67);
            lbFacultad.Margin = new Padding(2, 0, 2, 0);
            lbFacultad.Name = "lbFacultad";
            lbFacultad.Size = new Size(64, 15);
            lbFacultad.TabIndex = 7;
            lbFacultad.Text = "FACULTAD";
            // 
            // lbFoto
            // 
            lbFoto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbFoto.AutoSize = true;
            lbFoto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFoto.Location = new Point(420, 127);
            lbFoto.Margin = new Padding(2, 0, 2, 0);
            lbFoto.Name = "lbFoto";
            lbFoto.Size = new Size(215, 15);
            lbFoto.TabIndex = 10;
            lbFoto.Text = "LOGO / FOTO DEL EMPRENDIMIENTO";
            // 
            // lbRubro
            // 
            lbRubro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbRubro.AutoSize = true;
            lbRubro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRubro.Location = new Point(13, 67);
            lbRubro.Margin = new Padding(2, 0, 2, 0);
            lbRubro.Name = "lbRubro";
            lbRubro.Size = new Size(49, 15);
            lbRubro.TabIndex = 9;
            lbRubro.Text = "RUBRO";
            // 
            // btnArchivo
            // 
            btnArchivo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnArchivo.BackgroundImage = (Image)resources.GetObject("btnArchivo.BackgroundImage");
            btnArchivo.BackgroundImageLayout = ImageLayout.Zoom;
            btnArchivo.Cursor = Cursors.Hand;
            btnArchivo.FlatAppearance.BorderSize = 0;
            btnArchivo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnArchivo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnArchivo.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnArchivo.Location = new Point(44, 20);
            btnArchivo.Margin = new Padding(2);
            btnArchivo.Name = "btnArchivo";
            btnArchivo.Size = new Size(133, 35);
            btnArchivo.TabIndex = 12;
            btnArchivo.UseVisualStyleBackColor = true;
            btnArchivo.Click += btnArchivo_Click;
            // 
            // ContenedorArchivoC1
            // 
            ContenedorArchivoC1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ContenedorArchivoC1.Controls.Add(label1);
            ContenedorArchivoC1.Controls.Add(btnArchivo);
            ContenedorArchivoC1.Location = new Point(420, 144);
            ContenedorArchivoC1.Margin = new Padding(0);
            ContenedorArchivoC1.Name = "ContenedorArchivoC1";
            ContenedorArchivoC1.Padding = new Padding(2);
            ContenedorArchivoC1.Size = new Size(215, 80);
            ContenedorArchivoC1.TabIndex = 13;
            ContenedorArchivoC1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(49, 57);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 19;
            label1.Text = "SELECCIONE ARCHIVO";
            // 
            // lbDescripcion
            // 
            lbDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbDescripcion.AutoSize = true;
            lbDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDescripcion.Location = new Point(13, 127);
            lbDescripcion.Margin = new Padding(2, 0, 2, 0);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(84, 15);
            lbDescripcion.TabIndex = 14;
            lbDescripcion.Text = "DESCRIPCION";
            // 
            // txtDescripcion1
            // 
            txtDescripcion1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion1.Location = new Point(13, 150);
            txtDescripcion1.Margin = new Padding(2);
            txtDescripcion1.Multiline = true;
            txtDescripcion1.Name = "txtDescripcion1";
            txtDescripcion1.Size = new Size(386, 74);
            txtDescripcion1.TabIndex = 15;
            // 
            // btnGuardar1
            // 
            btnGuardar1.Anchor = AnchorStyles.Bottom;
            btnGuardar1.BackColor = Color.IndianRed;
            btnGuardar1.FlatStyle = FlatStyle.Flat;
            btnGuardar1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar1.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar1.Location = new Point(300, 237);
            btnGuardar1.Margin = new Padding(2);
            btnGuardar1.Name = "btnGuardar1";
            btnGuardar1.Size = new Size(154, 43);
            btnGuardar1.TabIndex = 16;
            btnGuardar1.Text = "GUARDAR REGISTRO";
            btnGuardar1.UseVisualStyleBackColor = false;
            btnGuardar1.Click += btnGuardar1_Click;
            // 
            // cBoxFacultadEmprendimiento
            // 
            cBoxFacultadEmprendimiento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cBoxFacultadEmprendimiento.FormattingEnabled = true;
            cBoxFacultadEmprendimiento.Items.AddRange(new object[] { "ADMINISTRACION CENTRAL", "ARQUITECTURA Y URBANISMO", "CIENCIAS ADMINISTRATIVAS", "CIENCIAS AGRARIAS", "CIENCIAS DE LA ACTIVIDAD FÍSICA", "CIENCIAS ECONÓMICAS", "CIENCIAS MATEMÁTICAS Y FÍSICAS" });
            cBoxFacultadEmprendimiento.Location = new Point(386, 90);
            cBoxFacultadEmprendimiento.Margin = new Padding(2);
            cBoxFacultadEmprendimiento.Name = "cBoxFacultadEmprendimiento";
            cBoxFacultadEmprendimiento.Size = new Size(249, 23);
            cBoxFacultadEmprendimiento.TabIndex = 17;
            // 
            // cBoxRubro
            // 
            cBoxRubro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cBoxRubro.FormattingEnabled = true;
            cBoxRubro.Items.AddRange(new object[] { "TECNOLOGÍA", "GASTRONOMÍA", "TEXTIL", "SERVICIOS", "SALUD" });
            cBoxRubro.Location = new Point(13, 90);
            cBoxRubro.Margin = new Padding(2);
            cBoxRubro.Name = "cBoxRubro";
            cBoxRubro.Size = new Size(281, 23);
            cBoxRubro.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(txtNombreE);
            panel1.Controls.Add(btnGuardar1);
            panel1.Controls.Add(cBoxRubro);
            panel1.Controls.Add(lbNombreE);
            panel1.Controls.Add(cBoxFacultadEmprendimiento);
            panel1.Controls.Add(lbFacultad);
            panel1.Controls.Add(lbRubro);
            panel1.Controls.Add(txtDescripcion1);
            panel1.Controls.Add(lbFoto);
            panel1.Controls.Add(lbDescripcion);
            panel1.Controls.Add(ContenedorArchivoC1);
            panel1.Location = new Point(0, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 291);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // panelRegistroEmp
            // 
            panelRegistroEmp.BackColor = Color.FromArgb(21, 113, 59);
            panelRegistroEmp.Controls.Add(lbInformacion);
            panelRegistroEmp.Controls.Add(pictureBox1);
            panelRegistroEmp.Controls.Add(labelEmprendimiento);
            panelRegistroEmp.Dock = DockStyle.Top;
            panelRegistroEmp.Location = new Point(0, 0);
            panelRegistroEmp.Name = "panelRegistroEmp";
            panelRegistroEmp.Size = new Size(697, 82);
            panelRegistroEmp.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FModuloAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(697, 395);
            Controls.Add(panelRegistroEmp);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "FModuloAdministrador";
            Text = "v ";
            Load += FModuloAdministrador_Load_1;
            ContenedorArchivoC1.ResumeLayout(false);
            ContenedorArchivoC1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelRegistroEmp.ResumeLayout(false);
            panelRegistroEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private Label label1;
        private Panel panel1;
        private Panel panelRegistroEmp;
        private PictureBox pictureBox1;
    }
}