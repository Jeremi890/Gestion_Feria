namespace ProyectoGestionDeFeria
{
    partial class FCalendario
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
            btnBuscarCalendario = new Button();
            dtCalendario = new DateTimePicker();
            cBoxFiltrarFacultad = new ComboBox();
            flowPanelEventos = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(461, 45);
            label1.TabIndex = 0;
            label1.Text = "📅 Calendario de Actividades";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 115);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 1;
            label2.Text = "Filtrar por Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(329, 115);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 3;
            label3.Text = "Filtrar por Facultad";
            label3.Click += label3_Click;
            // 
            // btnBuscarCalendario
            // 
            btnBuscarCalendario.FlatAppearance.BorderSize = 0;
            btnBuscarCalendario.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnBuscarCalendario.FlatStyle = FlatStyle.Flat;
            btnBuscarCalendario.Location = new Point(757, 151);
            btnBuscarCalendario.Name = "btnBuscarCalendario";
            btnBuscarCalendario.Size = new Size(53, 34);
            btnBuscarCalendario.TabIndex = 5;
            btnBuscarCalendario.Text = "🔍";
            btnBuscarCalendario.UseVisualStyleBackColor = true;
            btnBuscarCalendario.Click += btnBuscarCalendario_Click;
            // 
            // dtCalendario
            // 
            dtCalendario.Format = DateTimePickerFormat.Short;
            dtCalendario.Location = new Point(29, 154);
            dtCalendario.Name = "dtCalendario";
            dtCalendario.Size = new Size(197, 31);
            dtCalendario.TabIndex = 7;
            // 
            // cBoxFiltrarFacultad
            // 
            cBoxFiltrarFacultad.FormattingEnabled = true;
            cBoxFiltrarFacultad.Items.AddRange(new object[] { "TODAS LAS FACULTADES", "ADMINISTRACION CENTRAL", "ARQUITECTURA Y URBANISMO", "CIENCIAS ADMINISTRATIVAS", "CIENCIAS AGRARIAS", "CIENCIAS DE LA ACTIVIDAD FÍSICA", "CIENCIAS ECONÓMICAS", "CIENCIAS MATEMÁTICAS Y FÍSICAS" });
            cBoxFiltrarFacultad.Location = new Point(329, 153);
            cBoxFiltrarFacultad.Name = "cBoxFiltrarFacultad";
            cBoxFiltrarFacultad.Size = new Size(422, 33);
            cBoxFiltrarFacultad.TabIndex = 8;
            // 
            // flowPanelEventos
            // 
            flowPanelEventos.AutoScroll = true;
            flowPanelEventos.BackColor = Color.WhiteSmoke;
            flowPanelEventos.Location = new Point(12, 214);
            flowPanelEventos.Name = "flowPanelEventos";
            flowPanelEventos.Size = new Size(798, 431);
            flowPanelEventos.TabIndex = 9;
            // 
            // FCalendario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 657);
            Controls.Add(flowPanelEventos);
            Controls.Add(cBoxFiltrarFacultad);
            Controls.Add(dtCalendario);
            Controls.Add(btnBuscarCalendario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FCalendario";
            Text = "FCalendario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnBuscarCalendario;
        private DateTimePicker dtCalendario;
        private ComboBox cBoxFiltrarFacultad;
        private FlowLayoutPanel flowPanelEventos;
    }
}