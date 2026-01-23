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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            PanelContenedor = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 9);
            label1.Name = "label1";
            label1.Size = new Size(707, 38);
            label1.TabIndex = 0;
            label1.Text = "🎓 Sistema de Gestión de Ferias de Emprendimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(299, 59);
            label2.Name = "label2";
            label2.Size = new Size(554, 25);
            label2.TabIndex = 1;
            label2.Text = "Universidad de Guayaquil - Plataforma de Gestión y Participación";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(164, 122);
            button1.Name = "button1";
            button1.Size = new Size(278, 51);
            button1.TabIndex = 2;
            button1.Text = "MÓDULO ADMINISTRADOR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(875, 122);
            button2.Name = "button2";
            button2.Size = new Size(278, 51);
            button2.TabIndex = 3;
            button2.Text = "MÓDULO ESTUDIANTE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = SystemColors.ActiveCaption;
            PanelContenedor.Location = new Point(12, 179);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1262, 859);
            PanelContenedor.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1286, 1050);
            Controls.Add(PanelContenedor);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Panel PanelContenedor;
    }
}
