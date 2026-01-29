using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGestionDeFeria
{
    public partial class FModuloEstudiante : Form
    {
        public FModuloEstudiante()
        {
            InitializeComponent();
        }
        //================================================================================
        private void btnConsultarEmprendimientos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FConsultarEmprendmiento());
        }
        //=====================================================================================
        private void btnCalendario2_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FCalendario());
        }
        //=====================================================================================
        private void btnGaleria_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FGaleriaFotos());
        }
        //=====================================================================================
        private void btnVotacion_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FVotacioncs());
        }
        //==============================================================================
        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            // Busca el panel principal
            Panel panelPrincipal = null;
            foreach (Control control in this.Controls)
            {
                if (control is Panel panel && panel.Height > 200)
                {
                    panelPrincipal = panel;
                    break;
                }
            }

            if (panelPrincipal == null) return;
            panelPrincipal.Controls.Clear();
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formularioHijo);
            formularioHijo.Show();
        }

        private void FModuloEstudiante_Load(object sender, EventArgs e)
        {
            panelizquierdo.BackColor = Color.FromArgb(29, 93, 117);
            // Quitar el borde visual
            btnCalendario2.FlatStyle = FlatStyle.Flat;
            btnCalendario2.FlatAppearance.BorderSize = 0;

            // Quitar márgenes de diseño
            btnCalendario2.Margin = new Padding(0);
            // Quitar el borde visual
            btnConsultarEmprendimientos.FlatStyle = FlatStyle.Flat;
            btnConsultarEmprendimientos.FlatAppearance.BorderSize = 0;

            // Quitar márgenes de diseño
            btnConsultarEmprendimientos.Margin = new Padding(0);
            // Quitar el borde visual
            btnGaleria.FlatStyle = FlatStyle.Flat;
            btnGaleria.FlatAppearance.BorderSize = 0;

            // Quitar márgenes de diseño
            btnGaleria.Margin = new Padding(0);
            btnConsultarEmprendimientos.Text = "CONSULTAR" + Environment.NewLine + "EMPRENDIMIENTO";
        }

        private void panelizquierdo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
    
        }
    }
}
