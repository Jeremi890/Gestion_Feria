namespace ProyectoGestionDeFeria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            PanelContenedor = new Panel();
            LogoUGcolor = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)LogoUGcolor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 8);
            label1.Name = "label1";
            label1.Size = new Size(707, 38);
            label1.TabIndex = 0;
            label1.Text = "🎓 Sistema de Gestión de Ferias de Emprendimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(299, 58);
            label2.Name = "label2";
            label2.Size = new Size(554, 25);
            label2.TabIndex = 1;
            label2.Text = "Universidad de Guayaquil - Plataforma de Gestión y Participación";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(324, 122);
            button1.Name = "button1";
            button1.Size = new Size(279, 52);
            button1.TabIndex = 2;
            button1.Text = "MÓDULO ADMINISTRADOR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(1034, 122);
            button2.Name = "button2";
            button2.Size = new Size(279, 52);
            button2.TabIndex = 3;
            button2.Text = "VISTA DEL ESTUDIANTE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.AutoScroll = true;
            PanelContenedor.AutoSize = true;
            PanelContenedor.BackColor = SystemColors.ActiveCaption;
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(0, 167);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1440, 768);
            PanelContenedor.TabIndex = 4;
            // 
            // LogoUGcolor
            // 
            LogoUGcolor.Image = (Image)resources.GetObject("LogoUGcolor.Image");
            LogoUGcolor.Location = new Point(17, 20);
            LogoUGcolor.Margin = new Padding(0);
            LogoUGcolor.Name = "LogoUGcolor";
            LogoUGcolor.Size = new Size(143, 103);
            LogoUGcolor.SizeMode = PictureBoxSizeMode.Zoom;
            LogoUGcolor.TabIndex = 6;
            LogoUGcolor.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1440, 167);
            panel1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1440, 935);
            Controls.Add(LogoUGcolor);
            Controls.Add(PanelContenedor);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)LogoUGcolor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Panel PanelContenedor;
        private PictureBox LogoUGcolor;
        private Panel panel1;
    }
}
