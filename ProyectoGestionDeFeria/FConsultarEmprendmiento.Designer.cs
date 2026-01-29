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
            label1 = new Label();
            label2 = new Label();
            txtFEmprendimiento = new TextBox();
            btnBuscarL = new Button();
            flowPanelContenedor = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(326, 30);
            label1.TabIndex = 0;
            label1.Text = "🔍 Explorar Emprendimientos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 63);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 1;
            label2.Text = "Buscar Emprendimiento";
            // 
            // txtFEmprendimiento
            // 
            txtFEmprendimiento.Location = new Point(22, 85);
            txtFEmprendimiento.Margin = new Padding(2);
            txtFEmprendimiento.Name = "txtFEmprendimiento";
            txtFEmprendimiento.Size = new Size(300, 23);
            txtFEmprendimiento.TabIndex = 2;
            // 
            // btnBuscarL
            // 
            btnBuscarL.FlatAppearance.BorderSize = 0;
            btnBuscarL.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnBuscarL.FlatStyle = FlatStyle.Flat;
            btnBuscarL.Location = new Point(325, 83);
            btnBuscarL.Margin = new Padding(2);
            btnBuscarL.Name = "btnBuscarL";
            btnBuscarL.Size = new Size(78, 20);
            btnBuscarL.TabIndex = 3;
            btnBuscarL.Text = "🔍";
            btnBuscarL.UseVisualStyleBackColor = true;
            btnBuscarL.Click += btnBuscarL_Click;
            // 
            // flowPanelContenedor
            // 
            flowPanelContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowPanelContenedor.AutoScroll = true;
            flowPanelContenedor.FlowDirection = FlowDirection.TopDown;
            flowPanelContenedor.Location = new Point(8, 119);
            flowPanelContenedor.Margin = new Padding(2);
            flowPanelContenedor.Name = "flowPanelContenedor";
            flowPanelContenedor.Size = new Size(644, 271);
            flowPanelContenedor.TabIndex = 4;
            flowPanelContenedor.WrapContents = false;
            // 
            // FConsultarEmprendmiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 398);
            Controls.Add(flowPanelContenedor);
            Controls.Add(btnBuscarL);
            Controls.Add(txtFEmprendimiento);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FConsultarEmprendmiento";
            Text = "FConsultarEmprendmiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFEmprendimiento;
        private Button btnBuscarL;
        private FlowLayoutPanel flowPanelContenedor;
    }
}