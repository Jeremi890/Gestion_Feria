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
            button1 = new Button();
            button2 = new Button();
            PanelContenedor = new Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(21, 113, 59);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(539, 1);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(174, 31);
            button1.TabIndex = 2;
            button1.Text = "MÓDULO ADMINISTRADOR";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(29, 93, 117);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(804, 1);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(153, 31);
            button2.TabIndex = 3;
            button2.Text = "VISTA DEL ESTUDIANTE";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.AutoScroll = true;
            PanelContenedor.AutoSize = true;
            PanelContenedor.BackColor = SystemColors.ActiveCaption;
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(0, 32);
            PanelContenedor.Margin = new Padding(2);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(959, 417);
            PanelContenedor.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(959, 32);
            panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(499, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(752, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(959, 449);
            Controls.Add(PanelContenedor);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Panel PanelContenedor;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
