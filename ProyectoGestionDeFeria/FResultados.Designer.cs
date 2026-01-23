namespace ProyectoGestionDeFeria
{
    partial class FResultados
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
            label4 = new Label();
            btnRegistrarGanador = new Button();
            btnExportar = new Button();
            label5 = new Label();
            dVPremioRegistrado = new DataGridView();
            cBoxCategoriaPremio = new ComboBox();
            cBoxEmprendimientoGanador = new ComboBox();
            cBoxPosicionGanador = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dVPremioRegistrado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 28);
            label1.Name = "label1";
            label1.Size = new Size(468, 45);
            label1.TabIndex = 0;
            label1.Text = "🏆 Resultados y Premiaciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 99);
            label2.Name = "label2";
            label2.Size = new Size(198, 25);
            label2.TabIndex = 1;
            label2.Text = "Categoría de Premio *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 197);
            label3.Name = "label3";
            label3.Size = new Size(244, 25);
            label3.TabIndex = 3;
            label3.Text = "Emprendimiento Ganador *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(412, 197);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 5;
            label4.Text = "Posición *";
            // 
            // btnRegistrarGanador
            // 
            btnRegistrarGanador.Location = new Point(35, 302);
            btnRegistrarGanador.Name = "btnRegistrarGanador";
            btnRegistrarGanador.Size = new Size(188, 34);
            btnRegistrarGanador.TabIndex = 7;
            btnRegistrarGanador.Text = "Registrar Ganador";
            btnRegistrarGanador.UseVisualStyleBackColor = true;
            btnRegistrarGanador.Click += btnRegistrarGanador_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(454, 302);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(188, 34);
            btnExportar.TabIndex = 8;
            btnExportar.Text = "Exportar a PDF";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 385);
            label5.Name = "label5";
            label5.Size = new Size(229, 25);
            label5.TabIndex = 9;
            label5.Text = "Premiaciones Registradas";
            // 
            // dVPremioRegistrado
            // 
            dVPremioRegistrado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dVPremioRegistrado.Location = new Point(12, 424);
            dVPremioRegistrado.Name = "dVPremioRegistrado";
            dVPremioRegistrado.RowHeadersWidth = 62;
            dVPremioRegistrado.Size = new Size(670, 235);
            dVPremioRegistrado.TabIndex = 10;
            // 
            // cBoxCategoriaPremio
            // 
            cBoxCategoriaPremio.FormattingEnabled = true;
            cBoxCategoriaPremio.Items.AddRange(new object[] { "Mejor Innovación tecnológica", "Mejor propuesta Gastronómica", "Mejor diseño", "Mejor impacto social", "Favorito del público" });
            cBoxCategoriaPremio.Location = new Point(30, 141);
            cBoxCategoriaPremio.Name = "cBoxCategoriaPremio";
            cBoxCategoriaPremio.Size = new Size(652, 33);
            cBoxCategoriaPremio.TabIndex = 11;
            // 
            // cBoxEmprendimientoGanador
            // 
            cBoxEmprendimientoGanador.FormattingEnabled = true;
            cBoxEmprendimientoGanador.Location = new Point(30, 236);
            cBoxEmprendimientoGanador.Name = "cBoxEmprendimientoGanador";
            cBoxEmprendimientoGanador.Size = new Size(297, 33);
            cBoxEmprendimientoGanador.TabIndex = 12;
            // 
            // cBoxPosicionGanador
            // 
            cBoxPosicionGanador.FormattingEnabled = true;
            cBoxPosicionGanador.Items.AddRange(new object[] { "PRIMER LUGAR", "SEGUNDO LUGAR", "TERCER LUGAR", "CUARTO LUGAR", "QUINTO LUGAR", "SEXTO LUGAR", "SEPTIMO LUGAR" });
            cBoxPosicionGanador.Location = new Point(412, 236);
            cBoxPosicionGanador.Name = "cBoxPosicionGanador";
            cBoxPosicionGanador.Size = new Size(270, 33);
            cBoxPosicionGanador.TabIndex = 13;
            // 
            // FResultados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(701, 671);
            Controls.Add(cBoxPosicionGanador);
            Controls.Add(cBoxEmprendimientoGanador);
            Controls.Add(cBoxCategoriaPremio);
            Controls.Add(dVPremioRegistrado);
            Controls.Add(label5);
            Controls.Add(btnExportar);
            Controls.Add(btnRegistrarGanador);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FResultados";
            Text = "FResultados";
            ((System.ComponentModel.ISupportInitialize)dVPremioRegistrado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRegistrarGanador;
        private Button btnExportar;
        private Label label5;
        private DataGridView dVPremioRegistrado;
        private ComboBox cBoxCategoriaPremio;
        private ComboBox cBoxEmprendimientoGanador;
        private ComboBox cBoxPosicionGanador;
    }
}