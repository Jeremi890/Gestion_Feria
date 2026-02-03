namespace ProyectoGestionDeFeria
{
    partial class FGestionEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGestionEventos));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtDía = new DateTimePicker();
            label4 = new Label();
            dtHora = new DateTimePicker();
            label5 = new Label();
            txtUbicacion = new TextBox();
            label6 = new Label();
            txtOrdenPresentacion = new TextBox();
            btnRegistrarCronograma = new Button();
            dVCronogramaActual = new DataGridView();
            label7 = new Label();
            cBoxGestionEmprendimiento = new ComboBox();
            label8 = new Label();
            panel1 = new Panel();
            panelGestionEventos = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dVCronogramaActual).BeginInit();
            panel1.SuspendLayout();
            panelGestionEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(429, 30);
            label1.TabIndex = 0;
            label1.Text = "GESTIÓN DE EVENTOS Y CRONOGRAMA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 8);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(177, 15);
            label2.TabIndex = 1;
            label2.Text = "SLECCIONE EMPRENDIMIENTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 82);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 3;
            label3.Text = "FECHA DE ECPOSICIÓN";
            // 
            // dtDía
            // 
            dtDía.Format = DateTimePickerFormat.Short;
            dtDía.Location = new Point(13, 115);
            dtDía.Margin = new Padding(2);
            dtDía.Name = "dtDía";
            dtDía.Size = new Size(102, 23);
            dtDía.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(173, 82);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 5;
            label4.Text = "HORA";
            // 
            // dtHora
            // 
            dtHora.Format = DateTimePickerFormat.Time;
            dtHora.Location = new Point(173, 115);
            dtHora.Margin = new Padding(2);
            dtHora.Name = "dtHora";
            dtHora.ShowUpDown = true;
            dtHora.Size = new Size(70, 23);
            dtHora.TabIndex = 6;
            dtHora.Value = new DateTime(2025, 11, 26, 23, 26, 0, 0);
            dtHora.ValueChanged += dtHora_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 162);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 7;
            label5.Text = "UBICACIÓN / STAND";
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(13, 193);
            txtUbicacion.Margin = new Padding(2);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(288, 23);
            txtUbicacion.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 250);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(155, 15);
            label6.TabIndex = 9;
            label6.Text = "ORDEN DE PRESENTACIÓN";
            // 
            // txtOrdenPresentacion
            // 
            txtOrdenPresentacion.Location = new Point(175, 247);
            txtOrdenPresentacion.Margin = new Padding(2);
            txtOrdenPresentacion.Name = "txtOrdenPresentacion";
            txtOrdenPresentacion.Size = new Size(67, 23);
            txtOrdenPresentacion.TabIndex = 10;
            // 
            // btnRegistrarCronograma
            // 
            btnRegistrarCronograma.BackColor = Color.IndianRed;
            btnRegistrarCronograma.Cursor = Cursors.Hand;
            btnRegistrarCronograma.FlatStyle = FlatStyle.Flat;
            btnRegistrarCronograma.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarCronograma.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrarCronograma.Location = new Point(81, 325);
            btnRegistrarCronograma.Margin = new Padding(2);
            btnRegistrarCronograma.Name = "btnRegistrarCronograma";
            btnRegistrarCronograma.Size = new Size(161, 47);
            btnRegistrarCronograma.TabIndex = 11;
            btnRegistrarCronograma.Text = "REGISTRAR EN CRONOGRAMA";
            btnRegistrarCronograma.UseVisualStyleBackColor = false;
            btnRegistrarCronograma.Click += btnRegistrarCronograma_Click_1;
            // 
            // dVCronogramaActual
            // 
            dVCronogramaActual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dVCronogramaActual.Location = new Point(12, 41);
            dVCronogramaActual.Margin = new Padding(2);
            dVCronogramaActual.Name = "dVCronogramaActual";
            dVCronogramaActual.RowHeadersWidth = 62;
            dVCronogramaActual.Size = new Size(388, 331);
            dVCronogramaActual.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 8);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(141, 15);
            label7.TabIndex = 13;
            label7.Text = "CRONOGRAMA ACTUAL";
            // 
            // cBoxGestionEmprendimiento
            // 
            cBoxGestionEmprendimiento.BackColor = Color.Silver;
            cBoxGestionEmprendimiento.FormattingEnabled = true;
            cBoxGestionEmprendimiento.Location = new Point(13, 41);
            cBoxGestionEmprendimiento.Margin = new Padding(2);
            cBoxGestionEmprendimiento.Name = "cBoxGestionEmprendimiento";
            cBoxGestionEmprendimiento.Size = new Size(285, 23);
            cBoxGestionEmprendimiento.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(123, 282);
            label8.Name = "label8";
            label8.Size = new Size(156, 15);
            label8.TabIndex = 15;
            label8.Text = "(ESPECIFIQUE UN NUMERO)";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnRegistrarCronograma);
            panel1.Controls.Add(cBoxGestionEmprendimiento);
            panel1.Controls.Add(dtDía);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtHora);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtOrdenPresentacion);
            panel1.Controls.Add(txtUbicacion);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 399);
            panel1.TabIndex = 16;
            // 
            // panelGestionEventos
            // 
            panelGestionEventos.Controls.Add(pictureBox1);
            panelGestionEventos.Controls.Add(label1);
            panelGestionEventos.Dock = DockStyle.Top;
            panelGestionEventos.Location = new Point(0, 0);
            panelGestionEventos.Name = "panelGestionEventos";
            panelGestionEventos.Size = new Size(760, 82);
            panelGestionEventos.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(dVCronogramaActual);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(332, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(411, 399);
            panel3.TabIndex = 18;
            // 
            // FGestionEventos
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(760, 491);
            Controls.Add(panelGestionEventos);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FGestionEventos";
            Text = "FGestionEventos";
            Load += FGestionEventos_Load_1;
            ((System.ComponentModel.ISupportInitialize)dVCronogramaActual).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelGestionEventos.ResumeLayout(false);
            panelGestionEventos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtDía;
        private Label label4;
        private DateTimePicker dtHora;
        private Label label5;
        private TextBox txtUbicacion;
        private Label label6;
        private TextBox txtOrdenPresentacion;
        private Button btnRegistrarCronograma;
        private DataGridView dVCronogramaActual;
        private Label label7;
        private ComboBox cBoxGestionEmprendimiento;
        private Label label8;
        private Panel panel1;
        private Panel panelGestionEventos;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}