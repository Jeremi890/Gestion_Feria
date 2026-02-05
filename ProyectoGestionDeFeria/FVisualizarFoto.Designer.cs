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
            ((System.ComponentModel.ISupportInitialize)pBoxFotoGrande).BeginInit();
            SuspendLayout();
            // 
            // pBoxFotoGrande
            // 
            pBoxFotoGrande.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pBoxFotoGrande.BorderStyle = BorderStyle.Fixed3D;
            pBoxFotoGrande.Location = new Point(8, 7);
            pBoxFotoGrande.Margin = new Padding(2, 2, 2, 2);
            pBoxFotoGrande.Name = "pBoxFotoGrande";
            pBoxFotoGrande.Size = new Size(316, 378);
            pBoxFotoGrande.TabIndex = 0;
            pBoxFotoGrande.TabStop = false;
            // 
            // lstComentarios
            // 
            lstComentarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstComentarios.FormattingEnabled = true;
            lstComentarios.ItemHeight = 15;
            lstComentarios.Location = new Point(328, 7);
            lstComentarios.Margin = new Padding(2, 2, 2, 2);
            lstComentarios.Name = "lstComentarios";
            lstComentarios.Size = new Size(224, 199);
            lstComentarios.TabIndex = 1;
            // 
            // txtNuevoComentario
            // 
            txtNuevoComentario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNuevoComentario.Location = new Point(328, 221);
            txtNuevoComentario.Margin = new Padding(2, 2, 2, 2);
            txtNuevoComentario.Multiline = true;
            txtNuevoComentario.Name = "txtNuevoComentario";
            txtNuevoComentario.Size = new Size(224, 123);
            txtNuevoComentario.TabIndex = 2;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(405, 358);
            btnEnviar.Margin = new Padding(2, 2, 2, 2);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(78, 20);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // FVisualizarFoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 391);
            Controls.Add(btnEnviar);
            Controls.Add(txtNuevoComentario);
            Controls.Add(lstComentarios);
            Controls.Add(pBoxFotoGrande);
            Margin = new Padding(2, 2, 2, 2);
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
    }
}