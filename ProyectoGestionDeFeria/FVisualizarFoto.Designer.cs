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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pBoxFotoGrande).BeginInit();
            SuspendLayout();
            // 
            // pBoxFotoGrande
            // 
            pBoxFotoGrande.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pBoxFotoGrande.BackColor = Color.FromArgb(224, 224, 224);
            pBoxFotoGrande.BorderStyle = BorderStyle.FixedSingle;
            pBoxFotoGrande.Location = new Point(8, 7);
            pBoxFotoGrande.Margin = new Padding(2);
            pBoxFotoGrande.Name = "pBoxFotoGrande";
            pBoxFotoGrande.Size = new Size(316, 378);
            pBoxFotoGrande.TabIndex = 0;
            pBoxFotoGrande.TabStop = false;
            // 
            // lstComentarios
            // 
            lstComentarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lstComentarios.BorderStyle = BorderStyle.FixedSingle;
            lstComentarios.FormattingEnabled = true;
            lstComentarios.ItemHeight = 15;
            lstComentarios.Location = new Point(328, 7);
            lstComentarios.Margin = new Padding(2);
            lstComentarios.Name = "lstComentarios";
            lstComentarios.Size = new Size(224, 197);
            lstComentarios.TabIndex = 1;
            // 
            // txtNuevoComentario
            // 
            txtNuevoComentario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtNuevoComentario.BorderStyle = BorderStyle.FixedSingle;
            txtNuevoComentario.Location = new Point(328, 227);
            txtNuevoComentario.Margin = new Padding(2);
            txtNuevoComentario.Multiline = true;
            txtNuevoComentario.Name = "txtNuevoComentario";
            txtNuevoComentario.Size = new Size(224, 117);
            txtNuevoComentario.TabIndex = 2;
            // 
            // btnEnviar
            // 
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
            // FVisualizarFoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 113, 59);
            ClientSize = new Size(559, 391);
            Controls.Add(label1);
            Controls.Add(btnEnviar);
            Controls.Add(txtNuevoComentario);
            Controls.Add(lstComentarios);
            Controls.Add(pBoxFotoGrande);
            Margin = new Padding(2);
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
        private Label label1;
    }
}