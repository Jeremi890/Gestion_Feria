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
            ((System.ComponentModel.ISupportInitialize)dVCronogramaActual).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(401, 30);
            label1.TabIndex = 0;
            label1.Text = "📅 Gestión de Eventos y Cronograma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 63);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 1;
            label2.Text = "Emprendimiento *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 210);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 3;
            label3.Text = "Fecha de Exposición *";
            // 
            // dtDía
            // 
            dtDía.Format = DateTimePickerFormat.Short;
            dtDía.Location = new Point(32, 234);
            dtDía.Margin = new Padding(2);
            dtDía.Name = "dtDía";
            dtDía.Size = new Size(102, 23);
            dtDía.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(192, 210);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 5;
            label4.Text = "Hora *";
            // 
            // dtHora
            // 
            dtHora.Format = DateTimePickerFormat.Time;
            dtHora.Location = new Point(192, 234);
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
            label5.Location = new Point(29, 136);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 7;
            label5.Text = "Ubicación/Stand *";
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(29, 158);
            txtUbicacion.Margin = new Padding(2);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(288, 23);
            txtUbicacion.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 298);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(142, 15);
            label6.TabIndex = 9;
            label6.Text = "Orden de Presentación *";
            // 
            // txtOrdenPresentacion
            // 
            txtOrdenPresentacion.Location = new Point(178, 295);
            txtOrdenPresentacion.Margin = new Padding(2);
            txtOrdenPresentacion.Name = "txtOrdenPresentacion";
            txtOrdenPresentacion.Size = new Size(67, 23);
            txtOrdenPresentacion.TabIndex = 10;
            // 
            // btnRegistrarCronograma
            // 
            btnRegistrarCronograma.Location = new Point(29, 376);
            btnRegistrarCronograma.Margin = new Padding(2);
            btnRegistrarCronograma.Name = "btnRegistrarCronograma";
            btnRegistrarCronograma.Size = new Size(161, 29);
            btnRegistrarCronograma.TabIndex = 11;
            btnRegistrarCronograma.Text = "Registrar en Cronograma";
            btnRegistrarCronograma.UseVisualStyleBackColor = true;
            btnRegistrarCronograma.Click += btnRegistrarCronograma_Click_1;
            // 
            // dVCronogramaActual
            // 
            dVCronogramaActual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dVCronogramaActual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dVCronogramaActual.Location = new Point(331, 85);
            dVCronogramaActual.Margin = new Padding(2);
            dVCronogramaActual.Name = "dVCronogramaActual";
            dVCronogramaActual.RowHeadersWidth = 62;
            dVCronogramaActual.Size = new Size(405, 364);
            dVCronogramaActual.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(331, 63);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(113, 15);
            label7.TabIndex = 13;
            label7.Text = "Cronograma Actual";
            // 
            // cBoxGestionEmprendimiento
            // 
            cBoxGestionEmprendimiento.FormattingEnabled = true;
            cBoxGestionEmprendimiento.Location = new Point(32, 85);
            cBoxGestionEmprendimiento.Margin = new Padding(2);
            cBoxGestionEmprendimiento.Name = "cBoxGestionEmprendimiento";
            cBoxGestionEmprendimiento.Size = new Size(285, 23);
            cBoxGestionEmprendimiento.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(143, 320);
            label8.Name = "label8";
            label8.Size = new Size(137, 15);
            label8.TabIndex = 15;
            label8.Text = "(Especifique un numero)";
            // 
            // FGestionEventos
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new Size(751, 473);
            Controls.Add(label8);
            Controls.Add(cBoxGestionEmprendimiento);
            Controls.Add(label7);
            Controls.Add(dVCronogramaActual);
            Controls.Add(btnRegistrarCronograma);
            Controls.Add(txtOrdenPresentacion);
            Controls.Add(label6);
            Controls.Add(txtUbicacion);
            Controls.Add(label5);
            Controls.Add(dtHora);
            Controls.Add(label4);
            Controls.Add(dtDía);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FGestionEventos";
            Text = "FGestionEventos";
            ((System.ComponentModel.ISupportInitialize)dVCronogramaActual).EndInit();
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
    }
}