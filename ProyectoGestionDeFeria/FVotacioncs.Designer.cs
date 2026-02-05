namespace ProyectoGestionDeFeria
{
    partial class FVotacioncs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVotacioncs));
            label1 = new Label();
            label2 = new Label();
            flowPanelVotacion = new FlowLayoutPanel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(204, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(348, 32);
            label1.TabIndex = 0;
            label1.Text = "VOTACIÓN Y PARTICIPACIÓN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(158, 50);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(453, 15);
            label2.TabIndex = 1;
            label2.Text = "¡Tu opinión cuenta! Vota por tu emprendimiento favorito y deja tus comentarios.";
            // 
            // flowPanelVotacion
            // 
            flowPanelVotacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowPanelVotacion.AutoScroll = true;
            flowPanelVotacion.FlowDirection = FlowDirection.TopDown;
            flowPanelVotacion.Location = new Point(0, 82);
            flowPanelVotacion.Margin = new Padding(2);
            flowPanelVotacion.Name = "flowPanelVotacion";
            flowPanelVotacion.Size = new Size(775, 581);
            flowPanelVotacion.TabIndex = 2;
            flowPanelVotacion.WrapContents = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(29, 93, 117);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(775, 82);
            panel2.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FVotacioncs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 663);
            Controls.Add(flowPanelVotacion);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FVotacioncs";
            Text = "FVotacioncs";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowPanelVotacion;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}