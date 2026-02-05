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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCalendario));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnBuscarCalendario = new Button();
            dtCalendario = new DateTimePicker();
            cBoxFiltrarFacultad = new ComboBox();
            flowPanelEventos = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(110, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(333, 30);
            label1.TabIndex = 0;
            label1.Text = "CALENDARIO DE ACTIVIDADES";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 8);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Filtrar por Fecha";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(293, 8);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 3;
            label3.Text = "Filtrar por Facultad";
            label3.Click += label3_Click;
            // 
            // btnBuscarCalendario
            // 
            btnBuscarCalendario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarCalendario.BackgroundImage = (Image)resources.GetObject("btnBuscarCalendario.BackgroundImage");
            btnBuscarCalendario.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscarCalendario.FlatAppearance.BorderSize = 0;
            btnBuscarCalendario.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnBuscarCalendario.FlatStyle = FlatStyle.Flat;
            btnBuscarCalendario.Location = new Point(536, 33);
            btnBuscarCalendario.Margin = new Padding(2);
            btnBuscarCalendario.Name = "btnBuscarCalendario";
            btnBuscarCalendario.Size = new Size(37, 20);
            btnBuscarCalendario.TabIndex = 5;
            btnBuscarCalendario.UseVisualStyleBackColor = true;
            btnBuscarCalendario.Click += btnBuscarCalendario_Click;
            // 
            // dtCalendario
            // 
            dtCalendario.Anchor = AnchorStyles.Top;
            dtCalendario.Format = DateTimePickerFormat.Short;
            dtCalendario.Location = new Point(14, 33);
            dtCalendario.Margin = new Padding(2);
            dtCalendario.Name = "dtCalendario";
            dtCalendario.Size = new Size(139, 23);
            dtCalendario.TabIndex = 7;
            // 
            // cBoxFiltrarFacultad
            // 
            cBoxFiltrarFacultad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cBoxFiltrarFacultad.FormattingEnabled = true;
            cBoxFiltrarFacultad.Items.AddRange(new object[] { "TODAS LAS FACULTADES", "ADMINISTRACION CENTRAL", "ARQUITECTURA Y URBANISMO", "CIENCIAS ADMINISTRATIVAS", "CIENCIAS AGRARIAS", "CIENCIAS DE LA ACTIVIDAD FÍSICA", "CIENCIAS ECONÓMICAS", "CIENCIAS MATEMÁTICAS Y FÍSICAS" });
            cBoxFiltrarFacultad.Location = new Point(170, 33);
            cBoxFiltrarFacultad.Margin = new Padding(2);
            cBoxFiltrarFacultad.Name = "cBoxFiltrarFacultad";
            cBoxFiltrarFacultad.Size = new Size(358, 23);
            cBoxFiltrarFacultad.TabIndex = 8;
            // 
            // flowPanelEventos
            // 
            flowPanelEventos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowPanelEventos.AutoScroll = true;
            flowPanelEventos.BackColor = Color.WhiteSmoke;
            flowPanelEventos.Location = new Point(0, 0);
            flowPanelEventos.Margin = new Padding(2);
            flowPanelEventos.Name = "flowPanelEventos";
            flowPanelEventos.Size = new Size(575, 264);
            flowPanelEventos.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 93, 117);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 66);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(flowPanelEventos);
            panel2.Location = new Point(0, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(575, 264);
            panel2.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AllowDrop = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.7427387F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.25726F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.Controls.Add(label3, 1, 1);
            tableLayoutPanel1.Controls.Add(btnBuscarCalendario, 2, 2);
            tableLayoutPanel1.Controls.Add(cBoxFiltrarFacultad, 1, 2);
            tableLayoutPanel1.Controls.Add(dtCalendario, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 66);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.38889F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 73.6111145F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(575, 59);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // FCalendario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(575, 394);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FCalendario";
            Text = "FCalendario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnBuscarCalendario;
        private DateTimePicker dtCalendario;
        private ComboBox cBoxFiltrarFacultad;
        private FlowLayoutPanel flowPanelEventos;
        private Panel panel1;
        private Panel panel2;
        public TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
    }
}