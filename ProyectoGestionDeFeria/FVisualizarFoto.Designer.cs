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
            pBoxFotoGrande.BorderStyle = BorderStyle.Fixed3D;
            pBoxFotoGrande.Location = new Point(12, 12);
            pBoxFotoGrande.Name = "pBoxFotoGrande";
            pBoxFotoGrande.Size = new Size(450, 628);
            pBoxFotoGrande.TabIndex = 0;
            pBoxFotoGrande.TabStop = false;
            // 
            // lstComentarios
            // 
            lstComentarios.FormattingEnabled = true;
            lstComentarios.ItemHeight = 25;
            lstComentarios.Location = new Point(468, 12);
            lstComentarios.Name = "lstComentarios";
            lstComentarios.Size = new Size(318, 329);
            lstComentarios.TabIndex = 1;
            // 
            // txtNuevoComentario
            // 
            txtNuevoComentario.Location = new Point(468, 368);
            txtNuevoComentario.Multiline = true;
            txtNuevoComentario.Name = "txtNuevoComentario";
            txtNuevoComentario.Size = new Size(318, 202);
            txtNuevoComentario.TabIndex = 2;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(578, 596);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(112, 34);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // FVisualizarFoto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 652);
            Controls.Add(btnEnviar);
            Controls.Add(txtNuevoComentario);
            Controls.Add(lstComentarios);
            Controls.Add(pBoxFotoGrande);
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