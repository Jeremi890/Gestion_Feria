namespace ProyectoGestionDeFeria
{
    partial class FDetalleEmprendimiento
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
            lblNombre = new Label();
            lblFacultad = new Label();
            lblRubro = new Label();
            pBoxFoto = new PictureBox();
            lblDescripcion = new Label();
            label1 = new Label();
            dgvParticipantes = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pBoxFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(15, 0);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(24, 22);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "d";
            // 
            // lblFacultad
            // 
            lblFacultad.AutoSize = true;
            lblFacultad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblFacultad.Location = new Point(15, 167);
            lblFacultad.Margin = new Padding(2, 0, 2, 0);
            lblFacultad.Name = "lblFacultad";
            lblFacultad.Size = new Size(14, 17);
            lblFacultad.TabIndex = 1;
            lblFacultad.Text = "c";
            // 
            // lblRubro
            // 
            lblRubro.AutoSize = true;
            lblRubro.BackColor = Color.Transparent;
            lblRubro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblRubro.ForeColor = Color.Black;
            lblRubro.Location = new Point(15, 203);
            lblRubro.Margin = new Padding(2, 0, 2, 0);
            lblRubro.Name = "lblRubro";
            lblRubro.Size = new Size(16, 17);
            lblRubro.TabIndex = 2;
            lblRubro.Text = "b";
            lblRubro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pBoxFoto
            // 
            pBoxFoto.BorderStyle = BorderStyle.FixedSingle;
            pBoxFoto.Location = new Point(13, 22);
            pBoxFoto.Margin = new Padding(0);
            pBoxFoto.Name = "pBoxFoto";
            pBoxFoto.Size = new Size(169, 140);
            pBoxFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxFoto.TabIndex = 3;
            pBoxFoto.TabStop = false;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblDescripcion.Location = new Point(15, 246);
            lblDescripcion.Margin = new Padding(2, 0, 2, 0);
            lblDescripcion.MaximumSize = new Size(280, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(15, 17);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "a";
            lblDescripcion.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(29, 93, 117);
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(190, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(504, 22);
            label1.TabIndex = 5;
            label1.Text = "INTEGRANTES DEL EQUIPO";
            // 
            // dgvParticipantes
            // 
            dgvParticipantes.AllowUserToAddRows = false;
            dgvParticipantes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvParticipantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParticipantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipantes.Location = new Point(190, 24);
            dgvParticipantes.Margin = new Padding(2);
            dgvParticipantes.Name = "dgvParticipantes";
            dgvParticipantes.ReadOnly = true;
            dgvParticipantes.RowHeadersVisible = false;
            dgvParticipantes.RowHeadersWidth = 62;
            dgvParticipantes.Size = new Size(504, 141);
            dgvParticipantes.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.85714F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 508F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            tableLayoutPanel1.Controls.Add(dgvParticipantes, 2, 1);
            tableLayoutPanel1.Controls.Add(label1, 2, 0);
            tableLayoutPanel1.Controls.Add(lblNombre, 1, 0);
            tableLayoutPanel1.Controls.Add(lblFacultad, 1, 2);
            tableLayoutPanel1.Controls.Add(lblRubro, 1, 3);
            tableLayoutPanel1.Controls.Add(lblDescripcion, 1, 4);
            tableLayoutPanel1.Controls.Add(pBoxFoto, 1, 1);
            tableLayoutPanel1.Controls.Add(btnCerrar, 2, 5);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 145F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(708, 357);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrar.BackColor = Color.IndianRed;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = SystemColors.ControlLightLight;
            btnCerrar.Location = new Point(188, 325);
            btnCerrar.Margin = new Padding(0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(95, 32);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FDetalleEmprendimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(708, 357);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "FDetalleEmprendimiento";
            Text = "FDetalleEmprendimiento";
            Load += FDetalleEmprendimiento_Load;
            ((System.ComponentModel.ISupportInitialize)pBoxFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private Label lblFacultad;
        private Label lblRubro;
        private PictureBox pBoxFoto;
        private Label lblDescripcion;
        private Label label1;
        private DataGridView dgvParticipantes;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnCerrar;
    }
}