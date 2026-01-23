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
            ((System.ComponentModel.ISupportInitialize)dVCronogramaActual).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 34);
            label1.Name = "label1";
            label1.Size = new Size(580, 45);
            label1.TabIndex = 0;
            label1.Text = "📅 Gestión de Eventos y Cronograma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 102);
            label2.Name = "label2";
            label2.Size = new Size(166, 25);
            label2.TabIndex = 1;
            label2.Text = "Emprendimiento *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 212);
            label3.Name = "label3";
            label3.Size = new Size(196, 25);
            label3.TabIndex = 3;
            label3.Text = "Fecha de Exposición *";
            // 
            // dtDía
            // 
            dtDía.Format = DateTimePickerFormat.Short;
            dtDía.Location = new Point(46, 252);
            dtDía.Name = "dtDía";
            dtDía.Size = new Size(300, 31);
            dtDía.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(684, 212);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 5;
            label4.Text = "Hora *";
            // 
            // dtHora
            // 
            dtHora.Format = DateTimePickerFormat.Time;
            dtHora.Location = new Point(684, 252);
            dtHora.Name = "dtHora";
            dtHora.Size = new Size(300, 31);
            dtHora.TabIndex = 6;
            dtHora.Value = new DateTime(2025, 11, 26, 23, 26, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 318);
            label5.Name = "label5";
            label5.Size = new Size(166, 25);
            label5.TabIndex = 7;
            label5.Text = "Ubicación/Stand *";
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(42, 358);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(304, 31);
            txtUbicacion.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(684, 318);
            label6.Name = "label6";
            label6.Size = new Size(219, 25);
            label6.TabIndex = 9;
            label6.Text = "Orden de Presentación *";
            // 
            // txtOrdenPresentacion
            // 
            txtOrdenPresentacion.Location = new Point(684, 358);
            txtOrdenPresentacion.Name = "txtOrdenPresentacion";
            txtOrdenPresentacion.Size = new Size(304, 31);
            txtOrdenPresentacion.TabIndex = 10;
            // 
            // btnRegistrarCronograma
            // 
            btnRegistrarCronograma.Location = new Point(395, 425);
            btnRegistrarCronograma.Name = "btnRegistrarCronograma";
            btnRegistrarCronograma.Size = new Size(230, 49);
            btnRegistrarCronograma.TabIndex = 11;
            btnRegistrarCronograma.Text = "Registrar en Cronograma";
            btnRegistrarCronograma.UseVisualStyleBackColor = true;
            btnRegistrarCronograma.Click += btnRegistrarCronograma_Click_1;
            // 
            // dVCronogramaActual
            // 
            dVCronogramaActual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dVCronogramaActual.Location = new Point(24, 565);
            dVCronogramaActual.Name = "dVCronogramaActual";
            dVCronogramaActual.RowHeadersWidth = 62;
            dVCronogramaActual.Size = new Size(964, 292);
            dVCronogramaActual.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 528);
            label7.Name = "label7";
            label7.Size = new Size(177, 25);
            label7.TabIndex = 13;
            label7.Text = "Cronograma Actual";
            // 
            // cBoxGestionEmprendimiento
            // 
            cBoxGestionEmprendimiento.FormattingEnabled = true;
            cBoxGestionEmprendimiento.Location = new Point(46, 141);
            cBoxGestionEmprendimiento.Name = "cBoxGestionEmprendimiento";
            cBoxGestionEmprendimiento.Size = new Size(942, 33);
            cBoxGestionEmprendimiento.TabIndex = 14;
            // 
            // FGestionEventos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1004, 869);
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
    }
}