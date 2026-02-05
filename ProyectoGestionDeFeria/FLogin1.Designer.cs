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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin1));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnAdmin = new Button();
            btnCerrar = new Button();
            btnEstudiante = new Button();
            pictureBox2 = new PictureBox();
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
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 331);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 161);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(169, 36);
            label2.TabIndex = 2;
            label2.Text = "Plataforma integral para la  gestión y \r\nseguimiento de ferias de \r\nemprendimientos estudiantiles.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 132);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 17);
            label1.TabIndex = 1;
            label1.Text = "EMPRENDE CON NOSOTROS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Orange;
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(229, 250);
            btnAdmin.Margin = new Padding(2);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(248, 31);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "INGRESAR COMO ADMINISTRADOR";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(497, 0);
            btnCerrar.Margin = new Padding(2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(27, 26);
            btnCerrar.TabIndex = 2;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnEstudiante
            // 
            btnEstudiante.BackColor = Color.DeepSkyBlue;
            btnEstudiante.Cursor = Cursors.Hand;
            btnEstudiante.FlatAppearance.BorderSize = 0;
            btnEstudiante.FlatStyle = FlatStyle.Flat;
            btnEstudiante.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            btnEstudiante.ForeColor = Color.White;
            btnEstudiante.Location = new Point(229, 289);
            btnEstudiante.Margin = new Padding(2);
            btnEstudiante.Name = "btnEstudiante";
            btnEstudiante.Size = new Size(248, 31);
            btnEstudiante.TabIndex = 3;
            btnEstudiante.Text = "INGRESAR COMO ESTUDIANTE";
            btnEstudiante.UseVisualStyleBackColor = false;
            btnEstudiante.Click += btnEstudiante_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(230, 0);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 139);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(253, 136);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(206, 25);
            label3.TabIndex = 5;
            label3.Text = "INGRESA AL SISTEMA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F);
            label4.Location = new Point(331, 161);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 13);
            label4.TabIndex = 6;
            label4.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(230, 176);
            txtUsuario.Margin = new Padding(2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(247, 23);
            txtUsuario.TabIndex = 7;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(230, 218);
            txtClave.Margin = new Padding(2);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(247, 23);
            txtClave.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F);
            label5.Location = new Point(322, 201);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 13);
            label5.TabIndex = 8;
            label5.Text = "Contraseña:";
            // 
            // FLogin1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(526, 331);
            Controls.Add(txtClave);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(btnAdmin);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnEstudiante);
            Controls.Add(btnCerrar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
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