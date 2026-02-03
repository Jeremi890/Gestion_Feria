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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FParticipantes));
            lbNombresP = new Label();
            lbEmprendimientoS = new Label();
            lbParticipantes = new Label();
            txtNombresP = new TextBox();
            txtApellidosP = new TextBox();
            lbApellidosP = new Label();
            lbCargoP = new Label();
            ContenedorArchivoC2 = new GroupBox();
            btnArchivo2 = new Button();
            label1 = new Label();
            lbFotoP = new Label();
            btnAgregarP = new Button();
            lbPartiR = new Label();
            dVParticipante = new DataGridView();
            cBoxSeleccionarERP = new ComboBox();
            cBoxCargo = new ComboBox();
            panel1 = new Panel();
            panelSupRegistro = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            IdParticipante = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            NombreEmprendimiento = new DataGridViewTextBoxColumn();
            ContenedorArchivoC2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dVParticipante).BeginInit();
            panel1.SuspendLayout();
            panelSupRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbNombresP
            // 
            lbNombresP.Anchor = AnchorStyles.Left;
            lbNombresP.AutoSize = true;
            lbNombresP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombresP.Location = new Point(11, 95);
            lbNombresP.Margin = new Padding(2, 0, 2, 0);
            lbNombresP.Name = "lbNombresP";
            lbNombresP.Size = new Size(101, 25);
            lbNombresP.TabIndex = 23;
            lbNombresP.Text = "NOMBRES";
            // 
            // lbEmprendimientoS
            // 
            lbEmprendimientoS.Anchor = AnchorStyles.Left;
            lbEmprendimientoS.AutoSize = true;
            lbEmprendimientoS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmprendimientoS.Location = new Point(11, 37);
            lbEmprendimientoS.Margin = new Padding(2, 0, 2, 0);
            lbEmprendimientoS.Name = "lbEmprendimientoS";
            lbEmprendimientoS.Size = new Size(314, 25);
            lbEmprendimientoS.TabIndex = 19;
            lbEmprendimientoS.Text = "SLECCIONAR EL EMPRENDIMIENTO";
            // 
            // lbParticipantes
            // 
            lbParticipantes.AutoSize = true;
            lbParticipantes.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbParticipantes.ForeColor = SystemColors.ControlLightLight;
            lbParticipantes.Location = new Point(205, 22);
            lbParticipantes.Margin = new Padding(2, 0, 2, 0);
            lbParticipantes.Name = "lbParticipantes";
            lbParticipantes.Size = new Size(472, 45);
            lbParticipantes.TabIndex = 17;
            lbParticipantes.Text = "REGISTRO DE PARTICIPANTES";
            // 
            // txtNombresP
            // 
            txtNombresP.Anchor = AnchorStyles.Left;
            txtNombresP.Location = new Point(11, 111);
            txtNombresP.Margin = new Padding(2);
            txtNombresP.Name = "txtNombresP";
            txtNombresP.Size = new Size(202, 31);
            txtNombresP.TabIndex = 31;
            // 
            // txtApellidosP
            // 
            txtApellidosP.Anchor = AnchorStyles.Left;
            txtApellidosP.Location = new Point(11, 165);
            txtApellidosP.Margin = new Padding(2);
            txtApellidosP.Name = "txtApellidosP";
            txtApellidosP.Size = new Size(202, 31);
            txtApellidosP.TabIndex = 33;
            // 
            // lbApellidosP
            // 
            lbApellidosP.Anchor = AnchorStyles.Left;
            lbApellidosP.AutoSize = true;
            lbApellidosP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbApellidosP.Location = new Point(11, 148);
            lbApellidosP.Margin = new Padding(2, 0, 2, 0);
            lbApellidosP.Name = "lbApellidosP";
            lbApellidosP.Size = new Size(107, 25);
            lbApellidosP.TabIndex = 32;
            lbApellidosP.Text = "APELLIDOS";
            // 
            // lbCargoP
            // 
            lbCargoP.Anchor = AnchorStyles.Left;
            lbCargoP.AutoSize = true;
            lbCargoP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCargoP.Location = new Point(11, 202);
            lbCargoP.Margin = new Padding(2, 0, 2, 0);
            lbCargoP.Name = "lbCargoP";
            lbCargoP.Size = new Size(174, 25);
            lbCargoP.TabIndex = 34;
            lbCargoP.Text = "CARGO / FUNCION";
            // 
            // ContenedorArchivoC2
            // 
            ContenedorArchivoC2.Anchor = AnchorStyles.Left;
            ContenedorArchivoC2.Controls.Add(btnArchivo2);
            ContenedorArchivoC2.Location = new Point(237, 111);
            ContenedorArchivoC2.Margin = new Padding(2);
            ContenedorArchivoC2.Name = "ContenedorArchivoC2";
            ContenedorArchivoC2.Padding = new Padding(2);
            ContenedorArchivoC2.Size = new Size(128, 112);
            ContenedorArchivoC2.TabIndex = 37;
            ContenedorArchivoC2.TabStop = false;
            // 
            // btnArchivo2
            // 
            btnArchivo2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnArchivo2.BackColor = SystemColors.Control;
            btnArchivo2.BackgroundImage = (Image)resources.GetObject("btnArchivo2.BackgroundImage");
            btnArchivo2.BackgroundImageLayout = ImageLayout.Zoom;
            btnArchivo2.Cursor = Cursors.Hand;
            btnArchivo2.FlatStyle = FlatStyle.Flat;
            btnArchivo2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnArchivo2.ForeColor = Color.Transparent;
            btnArchivo2.Location = new Point(18, 14);
            btnArchivo2.Margin = new Padding(0);
            btnArchivo2.Name = "btnArchivo2";
            btnArchivo2.Size = new Size(86, 92);
            btnArchivo2.TabIndex = 12;
            btnArchivo2.UseVisualStyleBackColor = false;
            btnArchivo2.Click += btnArchivo2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(228, 225);
            label1.Name = "label1";
            label1.Size = new Size(225, 25);
            label1.TabIndex = 43;
            label1.Text = "SELECCIONE UNA IMAGEN";
            // 
            // lbFotoP
            // 
            lbFotoP.Anchor = AnchorStyles.Left;
            lbFotoP.AutoSize = true;
            lbFotoP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFotoP.Location = new Point(246, 95);
            lbFotoP.Margin = new Padding(2, 0, 2, 0);
            lbFotoP.Name = "lbFotoP";
            lbFotoP.Size = new Size(168, 25);
            lbFotoP.TabIndex = 36;
            lbFotoP.Text = "FOTO INDIVIDUAL";
            lbFotoP.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAgregarP
            // 
            btnAgregarP.Anchor = AnchorStyles.Left;
            btnAgregarP.BackColor = Color.IndianRed;
            btnAgregarP.FlatStyle = FlatStyle.Flat;
            btnAgregarP.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarP.ForeColor = SystemColors.ControlLightLight;
            btnAgregarP.Location = new Point(129, 271);
            btnAgregarP.Margin = new Padding(2);
            btnAgregarP.Name = "btnAgregarP";
            btnAgregarP.Size = new Size(179, 32);
            btnAgregarP.TabIndex = 38;
            btnAgregarP.Text = "AGREGAR PARTICIPANTE";
            btnAgregarP.UseVisualStyleBackColor = false;
            btnAgregarP.Click += btnAgregarP_Click;
            // 
            // lbPartiR
            // 
            lbPartiR.Anchor = AnchorStyles.Top;
            lbPartiR.AutoSize = true;
            lbPartiR.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPartiR.Location = new Point(82, 37);
            lbPartiR.Margin = new Padding(2, 0, 2, 0);
            lbPartiR.Name = "lbPartiR";
            lbPartiR.Size = new Size(278, 25);
            lbPartiR.TabIndex = 39;
            lbPartiR.Text = "PARTICIPANTES REGISTRADOS";
            // 
            // dVParticipante
            // 
            dVParticipante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dVParticipante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dVParticipante.Columns.AddRange(new DataGridViewColumn[] { IdParticipante, Nombre, Apellido, Cargo, NombreEmprendimiento });
            dVParticipante.Location = new Point(27, 70);
            dVParticipante.Margin = new Padding(2);
            dVParticipante.Name = "dVParticipante";
            dVParticipante.RowHeadersWidth = 62;
            dVParticipante.Size = new Size(291, 420);
            dVParticipante.TabIndex = 40;
            dVParticipante.CellEndEdit += dVParticipante_CellEndEdit;
            // 
            // cBoxSeleccionarERP
            // 
            cBoxSeleccionarERP.Anchor = AnchorStyles.Left;
            cBoxSeleccionarERP.FormattingEnabled = true;
            cBoxSeleccionarERP.Location = new Point(11, 54);
            cBoxSeleccionarERP.Margin = new Padding(2);
            cBoxSeleccionarERP.Name = "cBoxSeleccionarERP";
            cBoxSeleccionarERP.Size = new Size(367, 33);
            cBoxSeleccionarERP.TabIndex = 41;
            cBoxSeleccionarERP.SelectedIndexChanged += cBoxSeleccionarERP_SelectedIndexChanged;
            // 
            // cBoxCargo
            // 
            cBoxCargo.Anchor = AnchorStyles.Left;
            cBoxCargo.FormattingEnabled = true;
            cBoxCargo.Items.AddRange(new object[] { "Lider de Proyecto", "Diseñador", "Expositor", "Desarrollador", "Marketing" });
            cBoxCargo.Location = new Point(11, 219);
            cBoxCargo.Margin = new Padding(2);
            cBoxCargo.Name = "cBoxCargo";
            cBoxCargo.Size = new Size(202, 33);
            cBoxCargo.TabIndex = 42;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbEmprendimientoS);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbNombresP);
            panel1.Controls.Add(cBoxCargo);
            panel1.Controls.Add(txtNombresP);
            panel1.Controls.Add(cBoxSeleccionarERP);
            panel1.Controls.Add(lbApellidosP);
            panel1.Controls.Add(txtApellidosP);
            panel1.Controls.Add(lbCargoP);
            panel1.Controls.Add(btnAgregarP);
            panel1.Controls.Add(lbFotoP);
            panel1.Controls.Add(ContenedorArchivoC2);
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 504);
            panel1.TabIndex = 44;
            // 
            // panelSupRegistro
            // 
            panelSupRegistro.AllowDrop = true;
            panelSupRegistro.Controls.Add(pictureBox1);
            panelSupRegistro.Controls.Add(lbParticipantes);
            panelSupRegistro.Dock = DockStyle.Top;
            panelSupRegistro.Location = new Point(0, 0);
            panelSupRegistro.Name = "panelSupRegistro";
            panelSupRegistro.Size = new Size(713, 82);
            panelSupRegistro.TabIndex = 45;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.AllowDrop = true;
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(lbPartiR);
            panel2.Controls.Add(dVParticipante);
            panel2.Location = new Point(384, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(329, 504);
            panel2.TabIndex = 46;
            // 
            // IdParticipante
            // 
            IdParticipante.DataPropertyName = "IdParticipante";
            IdParticipante.HeaderText = "ID";
            IdParticipante.MinimumWidth = 8;
            IdParticipante.Name = "IdParticipante";
            IdParticipante.Visible = false;
            IdParticipante.Width = 150;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            Apellido.Width = 150;
            // 
            // Cargo
            // 
            Cargo.DataPropertyName = "Cargo";
            Cargo.HeaderText = "Cargo";
            Cargo.MinimumWidth = 8;
            Cargo.Name = "Cargo";
            Cargo.Width = 150;
            // 
            // NombreEmprendimiento
            // 
            NombreEmprendimiento.DataPropertyName = "NombreEmprendimiento";
            NombreEmprendimiento.HeaderText = "Emprendimiento";
            NombreEmprendimiento.MinimumWidth = 8;
            NombreEmprendimiento.Name = "NombreEmprendimiento";
            NombreEmprendimiento.ReadOnly = true;
            NombreEmprendimiento.Width = 150;
            // 
            // FParticipantes
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            ClientSize = new Size(713, 558);
            Controls.Add(panelSupRegistro);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FParticipantes";
            Text = "FParticipantes";
            Load += FParticipantes_Load;
            ContenedorArchivoC2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dVParticipante).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelSupRegistro.ResumeLayout(false);
            panelSupRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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
        private Label label1;
        private Panel panel1;
        private Panel panelSupRegistro;
        private Panel panel2;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn IdParticipante;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn NombreEmprendimiento;
    }
}