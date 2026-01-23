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
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pBoxFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 38);
            lblNombre.TabIndex = 0;
            // 
            // lblFacultad
            // 
            lblFacultad.AutoSize = true;
            lblFacultad.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFacultad.Location = new Point(21, 63);
            lblFacultad.Name = "lblFacultad";
            lblFacultad.Size = new Size(0, 28);
            lblFacultad.TabIndex = 1;
            // 
            // lblRubro
            // 
            lblRubro.AutoSize = true;
            lblRubro.BackColor = Color.RoyalBlue;
            lblRubro.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRubro.ForeColor = Color.White;
            lblRubro.Location = new Point(462, 9);
            lblRubro.Name = "lblRubro";
            lblRubro.Size = new Size(0, 28);
            lblRubro.TabIndex = 2;
            lblRubro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pBoxFoto
            // 
            pBoxFoto.BorderStyle = BorderStyle.FixedSingle;
            pBoxFoto.Location = new Point(21, 104);
            pBoxFoto.Name = "pBoxFoto";
            pBoxFoto.Size = new Size(200, 200);
            pBoxFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxFoto.TabIndex = 3;
            pBoxFoto.TabStop = false;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(236, 124);
            lblDescripcion.MaximumSize = new Size(400, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(0, 28);
            lblDescripcion.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 319);
            label1.Name = "label1";
            label1.Size = new Size(349, 28);
            label1.TabIndex = 5;
            label1.Text = "Integrantes del Equipo";
            // 
            // dgvParticipantes
            // 
            dgvParticipantes.AllowUserToAddRows = false;
            dgvParticipantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParticipantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipantes.Location = new Point(12, 360);
            dgvParticipantes.Name = "dgvParticipantes";
            dgvParticipantes.ReadOnly = true;
            dgvParticipantes.RowHeadersVisible = false;
            dgvParticipantes.RowHeadersWidth = 62;
            dgvParticipantes.Size = new Size(573, 234);
            dgvParticipantes.TabIndex = 6;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(219, 600);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(112, 34);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FDetalleEmprendimiento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 638);
            Controls.Add(btnCerrar);
            Controls.Add(dgvParticipantes);
            Controls.Add(label1);
            Controls.Add(lblDescripcion);
            Controls.Add(pBoxFoto);
            Controls.Add(lblRubro);
            Controls.Add(lblFacultad);
            Controls.Add(lblNombre);
            Name = "FDetalleEmprendimiento";
            Text = "FDetalleEmprendimiento";
            Load += FDetalleEmprendimiento_Load;
            ((System.ComponentModel.ISupportInitialize)pBoxFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblFacultad;
        private Label lblRubro;
        private PictureBox pBoxFoto;
        private Label lblDescripcion;
        private Label label1;
        private DataGridView dgvParticipantes;
        private Button btnCerrar;
    }
}