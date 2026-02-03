namespace ProyectoGestionDeFeria
{
    partial class FGaleriaFotos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGaleriaFotos));
            flowPanelGaleria = new FlowLayoutPanel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowPanelGaleria
            // 
            flowPanelGaleria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowPanelGaleria.AutoScroll = true;
            flowPanelGaleria.BackColor = Color.FromArgb(224, 224, 224);
            flowPanelGaleria.Location = new Point(8, 97);
            flowPanelGaleria.Margin = new Padding(2);
            flowPanelGaleria.Name = "flowPanelGaleria";
            flowPanelGaleria.Size = new Size(689, 289);
            flowPanelGaleria.TabIndex = 0;
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
            panel2.Size = new Size(706, 82);
            panel2.TabIndex = 17;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(204, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(263, 32);
            label1.TabIndex = 0;
            label1.Text = "GALERIA DEL EVENTO";
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
            // FGaleriaFotos
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(706, 398);
            Controls.Add(panel2);
            Controls.Add(flowPanelGaleria);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FGaleriaFotos";
            Text = "FGaleriaFotos";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowPanelGaleria;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}