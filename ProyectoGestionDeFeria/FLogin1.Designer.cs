namespace ProyectoGestionDeFeria
{
    partial class FLogin1
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
            panel1 = new Panel();
            btnAdmin = new Button();
            btnCerrar = new Button();
            btnEstudiante = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 440);
            panel1.TabIndex = 0;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Orange;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(283, 329);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(355, 34);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "INGRESAR COMO ADMINISTRADOR";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.ButtonHighlight;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Location = new Point(599, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(39, 34);
            btnCerrar.TabIndex = 2;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnEstudiante
            // 
            btnEstudiante.BackColor = Color.DeepSkyBlue;
            btnEstudiante.FlatAppearance.BorderSize = 0;
            btnEstudiante.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnEstudiante.ForeColor = Color.White;
            btnEstudiante.Location = new Point(283, 380);
            btnEstudiante.Name = "btnEstudiante";
            btnEstudiante.Size = new Size(355, 34);
            btnEstudiante.TabIndex = 3;
            btnEstudiante.Text = "INGRESAR COMO ESTUDIANTE";
            btnEstudiante.UseVisualStyleBackColor = false;
            btnEstudiante.Click += btnEstudiante_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(33, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(320, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(198, 124);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 177);
            label1.Name = "label1";
            label1.Size = new Size(216, 25);
            label1.TabIndex = 1;
            label1.Text = "Emprende con Nosotros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 219);
            label2.Name = "label2";
            label2.Size = new Size(203, 45);
            label2.TabIndex = 2;
            label2.Text = "Plataforma integral para la  gestión y \r\nseguimiento de ferias de \r\nemprendimientos estudiantiles.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(274, 127);
            label3.Name = "label3";
            label3.Size = new Size(317, 38);
            label3.TabIndex = 5;
            label3.Text = "INGRESA AL SISTEMA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(281, 182);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 6;
            label4.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(283, 206);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(258, 31);
            txtUsuario.TabIndex = 7;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(285, 276);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(258, 31);
            txtClave.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(283, 252);
            label5.Name = "label5";
            label5.Size = new Size(96, 21);
            label5.TabIndex = 8;
            label5.Text = "Contraseña";
            // 
            // FLogin1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 440);
            Controls.Add(txtClave);
            Controls.Add(label5);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(btnEstudiante);
            Controls.Add(btnCerrar);
            Controls.Add(btnAdmin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FLogin1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FLogin1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnAdmin;
        private Button btnCerrar;
        private Button btnEstudiante;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Label label5;
    }
}