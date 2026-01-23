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
            label1 = new Label();
            flowPanelGaleria = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(483, 45);
            label1.TabIndex = 0;
            label1.Text = "📸 Galería de Fotos del Evento";
            // 
            // flowPanelGaleria
            // 
            flowPanelGaleria.AutoScroll = true;
            flowPanelGaleria.BackColor = Color.FromArgb(224, 224, 224);
            flowPanelGaleria.Location = new Point(12, 71);
            flowPanelGaleria.Name = "flowPanelGaleria";
            flowPanelGaleria.Size = new Size(607, 572);
            flowPanelGaleria.TabIndex = 9;
            // 
            // FGaleriaFotos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(631, 664);
            Controls.Add(flowPanelGaleria);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FGaleriaFotos";
            Text = "FGaleriaFotos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowPanelGaleria;
    }
}