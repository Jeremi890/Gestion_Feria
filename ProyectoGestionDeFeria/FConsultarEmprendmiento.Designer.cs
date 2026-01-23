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
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(474, 45);
            label1.TabIndex = 0;
            label1.Text = "🔍 Explorar Emprendimientos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 105);
            label2.Name = "label2";
            label2.Size = new Size(215, 25);
            label2.TabIndex = 1;
            label2.Text = "Buscar Emprendimiento";
            // 
            // txtFEmprendimiento
            // 
            txtFEmprendimiento.Location = new Point(31, 142);
            txtFEmprendimiento.Name = "txtFEmprendimiento";
            txtFEmprendimiento.Size = new Size(427, 31);
            txtFEmprendimiento.TabIndex = 2;
            // 
            // btnBuscarL
            // 
            btnBuscarL.FlatAppearance.BorderSize = 0;
            btnBuscarL.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnBuscarL.FlatStyle = FlatStyle.Flat;
            btnBuscarL.Location = new Point(464, 139);
            btnBuscarL.Name = "btnBuscarL";
            btnBuscarL.Size = new Size(112, 34);
            btnBuscarL.TabIndex = 3;
            btnBuscarL.Text = "🔍";
            btnBuscarL.UseVisualStyleBackColor = true;
            btnBuscarL.Click += btnBuscarL_Click;
            // 
            // flowPanelContenedor
            // 
            flowPanelContenedor.AutoScroll = true;
            flowPanelContenedor.FlowDirection = FlowDirection.TopDown;
            flowPanelContenedor.Location = new Point(12, 199);
            flowPanelContenedor.Name = "flowPanelContenedor";
            flowPanelContenedor.Size = new Size(920, 452);
            flowPanelContenedor.TabIndex = 4;
            flowPanelContenedor.WrapContents = false;
            // 
            // FConsultarEmprendmiento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 663);
            Controls.Add(flowPanelContenedor);
            Controls.Add(btnBuscarL);
            Controls.Add(txtFEmprendimiento);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
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