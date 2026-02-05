namespace ProyectoGestionDeFeria
{
    partial class FConsultarEmprendmiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConsultarEmprendmiento));
            label1 = new Label();
            panel1 = new Panel();
            btnBuscarL = new Button();
            flowPanelContenedor = new FlowLayoutPanel();
            txtFEmprendimiento = new TextBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(340, 30);
            label1.TabIndex = 0;
            label1.Text = "EXPLORAR EMPRENDIMIENTOS";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(29, 93, 117);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 82);
            panel1.TabIndex = 6;
            panel1.TabStop = true;
            // 
            // btnBuscarL
            // 
            btnBuscarL.BackgroundImage = (Image)resources.GetObject("btnBuscarL.BackgroundImage");
            btnBuscarL.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscarL.FlatAppearance.BorderSize = 0;
            btnBuscarL.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnBuscarL.FlatStyle = FlatStyle.Flat;
            btnBuscarL.Location = new Point(626, 102);
            btnBuscarL.Margin = new Padding(2);
            btnBuscarL.Name = "btnBuscarL";
            btnBuscarL.Size = new Size(24, 23);
            btnBuscarL.TabIndex = 3;
            btnBuscarL.UseVisualStyleBackColor = true;
            btnBuscarL.Click += btnBuscarL_Click;
            // 
            // flowPanelContenedor
            // 
            flowPanelContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowPanelContenedor.AutoScroll = true;
            flowPanelContenedor.FlowDirection = FlowDirection.BottomUp;
            flowPanelContenedor.Location = new Point(0, 129);
            flowPanelContenedor.Margin = new Padding(2);
            flowPanelContenedor.Name = "flowPanelContenedor";
            flowPanelContenedor.Size = new Size(657, 268);
            flowPanelContenedor.TabIndex = 4;
            flowPanelContenedor.WrapContents = false;
            // 
            // txtFEmprendimiento
            // 
            txtFEmprendimiento.Location = new Point(11, 102);
            txtFEmprendimiento.Margin = new Padding(2);
            txtFEmprendimiento.Name = "txtFEmprendimiento";
            txtFEmprendimiento.Size = new Size(602, 23);
            txtFEmprendimiento.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 85);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 15);
            label2.TabIndex = 1;
            label2.Text = "BUSCAR EMPRENDIMENTO";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(0, 168);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(661, 229);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FConsultarEmprendmiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 398);
            Controls.Add(flowPanelContenedor);
            Controls.Add(txtFEmprendimiento);
            Controls.Add(btnBuscarL);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FConsultarEmprendmiento";
            Text = "FConsultarEmprendmiento";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnBuscarL;
        private FlowLayoutPanel flowPanelContenedor;
        private TextBox txtFEmprendimiento;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
    }
}