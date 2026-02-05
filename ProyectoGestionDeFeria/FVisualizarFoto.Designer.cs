namespace ProyectoGestionDeFeria
{
    partial class FVisualizarFoto
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
            pBoxFotoGrande = new PictureBox();
            lstComentarios = new ListBox();
            txtNuevoComentario = new TextBox();
            btnEnviar = new Button();
<<<<<<< HEAD
            label1 = new Label();
=======
>>>>>>> 29aa1e6df64c8952b0dabdd480ff8a8558de8725
            ((System.ComponentModel.ISupportInitialize)pBoxFotoGrande).BeginInit();
            SuspendLayout();
            // 
            // pBoxFotoGrande
            // 
            pBoxFotoGrande.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
<<<<<<< HEAD
            pBoxFotoGrande.BackColor = Color.FromArgb(224, 224, 224);
            pBoxFotoGrande.BorderStyle = BorderStyle.FixedSingle;
            pBoxFotoGrande.Location = new Point(8, 7);
            pBoxFotoGrande.Margin = new Padding(2);
=======
            pBoxFotoGrande.BorderStyle = BorderStyle.Fixed3D;
            pBoxFotoGrande.Location = new Point(8, 7);
            pBoxFotoGrande.Margin = new Padding(2, 2, 2, 2);
>>>>>>> 29aa1e6df64c8952b0dabdd480ff8a8558de8725
            pBoxFotoGrande.Name = "pBoxFotoGrande";
            pBoxFotoGrande.Size = new Size(316, 378);
            pBoxFotoGrande.TabIndex = 0;
            pBoxFotoGrande.TabStop = false;
            // 
            // lstComentarios
            // 
<<<<<<< HEAD
            lstComentarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lstComentarios.BorderStyle = BorderStyle.FixedSingle;
            lstComentarios.FormattingEnabled = true;
            lstComentarios.ItemHeight = 15;
            lstComentarios.Location = new Point(328, 7);
            lstComentarios.Margin = new Padding(2);
            lstComentarios.Name = "lstComentarios";
            lstComentarios.Size = new Size(224, 197);
=======
            lstComentarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstComentarios.FormattingEnabled = true;
            lstComentarios.ItemHeight = 15;
            lstComentarios.Location = new Point(328, 7);
            lstComentarios.Margin = new Padding(2, 2, 2, 2);
            lstComentarios.Name = "lstComentarios";
            lstComentarios.Size = new Size(224, 199);
>>>>>>> 29aa1e6df64c8952b0dabdd480ff8a8558de8725
            lstComentarios.TabIndex = 1;
            // 
            // txtNuevoComentario
            // 
<<<<<<< HEAD
            txtNuevoComentario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtNuevoComentario.BorderStyle = BorderStyle.FixedSingle;
            txtNuevoComentario.Location = new Point(328, 227);
            txtNuevoComentario.Margin = new Padding(2);
            txtNuevoComentario.Multiline = true;
            txtNuevoComentario.Name = "txtNuevoComentario";
            txtNuevoComentario.Size = new Size(224, 117);
=======
            txtNuevoComentario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNuevoComentario.Location = new Point(328, 221);
            txtNuevoComentario.Margin = new Padding(2, 2, 2, 2);
            txtNuevoComentario.Multiline = true;
            txtNuevoComentario.Name = "txtNuevoComentario";
            txtNuevoComentario.Size = new Size(224, 123);
>>>>>>> 29aa1e6df64c8952b0dabdd480ff8a8558de8725
            txtNuevoComentario.TabIndex = 2;
            // 
            // btnEnviar
            // 
<<<<<<< HEAD
            btnEnviar.BackColor = Color.IndianRed;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.ForeColor = SystemColors.ControlLightLight;
            btnEnviar.Location = new Point(401, 355);
            btnEnviar.Margin = new Padding(2);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(78, 30);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(328, 210);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 4;
            label1.Text = "INGRESE SU COMENTARIO:";
            // 
=======
            btnEnviar.Location = new Point(405, 358);
            btnEnviar.Margin = new Padding(2, 2, 2, 2);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(78, 20);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
>>>>>>> 29aa1e6df64c8952b0dabdd480ff8a8558de8725
            // FVisualizarFoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            BackColor = Color.FromArgb(21, 113, 59);
            ClientSize = new Size(559, 391);
            Controls.Add(label1);
=======
            ClientSize = new Size(559, 391);
>>>>>>> 29aa1e6df64c8952b0dabdd480ff8a8558de8725
            Controls.Add(btnEnviar);
            Controls.Add(txtNuevoComentario);
            Controls.Add(lstComentarios);
            Controls.Add(pBoxFotoGrande);
<<<<<<< HEAD
            Margin = new Padding(2);
=======
            Margin = new Padding(2, 2, 2, 2);
>>>>>>> 29aa1e6df64c8952b0dabdd480ff8a8558de8725
            Name = "FVisualizarFoto";
            Text = "FVisualizarFoto";
            ((System.ComponentModel.ISupportInitialize)pBoxFotoGrande).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pBoxFotoGrande;
        private ListBox lstComentarios;
        private TextBox txtNuevoComentario;
        private Button btnEnviar;
<<<<<<< HEAD
        private Label label1;
=======
>>>>>>> 29aa1e6df64c8952b0dabdd480ff8a8558de8725
    }
}