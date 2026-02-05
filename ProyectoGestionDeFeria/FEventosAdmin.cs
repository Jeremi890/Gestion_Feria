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
    public partial class FEventosAdmin : Form
    {

        public FEventosAdmin()
        {
            InitializeComponent();
        }

        private void btnRegistrarEmprendimiento_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FModuloAdministrador());
        }
        //============================================================================
        private void btnParticipantes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FParticipantes());
        }
        //============================================================================
        private void btnGestionEventos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FGestionEventos());
        }
        //============================================================================
        private void btnResultados_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FResultados());
        }
        //============================================================================
        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            if (PanelDesarrollo1.Controls.Count > 0)
            {
                PanelDesarrollo1.Controls.Clear();
            }

            // Configura el formulario hijo
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            // Agrega y muestra el formulario
            PanelDesarrollo1.Controls.Add(formularioHijo);
            PanelDesarrollo1.Tag = formularioHijo;
            formularioHijo.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormularioEnPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FEventosAdmin_Load(object sender, EventArgs e)
        {
            // Quitar el borde visual
            btnRegistrarEmprendimiento.FlatStyle = FlatStyle.Flat;
            btnRegistrarEmprendimiento.FlatAppearance.BorderSize = 0;

            // Quitar márgenes de diseño
            btnRegistrarEmprendimiento.Margin = new Padding(0);
            // Quitar el borde visual
            btnParticipantes.FlatStyle = FlatStyle.Flat;
            btnParticipantes.FlatAppearance.BorderSize = 0;

            // Quitar márgenes de diseño
            btnResultados.Margin = new Padding(0);
            // Quitar el borde visual
            btnResultados.FlatStyle = FlatStyle.Flat;
            btnResultados.FlatAppearance.BorderSize = 0;
            // Quitar márgenes de diseño
            btnGestionEventos.Margin = new Padding(0);
            // Quitar el borde visual
            btnGestionEventos.FlatStyle = FlatStyle.Flat;
            btnGestionEventos.FlatAppearance.BorderSize = 0;

            panelizquierdoAdmin.BackColor = Color.FromArgb(21, 113, 59);
            btnRegistrarEmprendimiento.Text = "REGISTRAR" + Environment.NewLine + "EMPRENDIMIENTO";
        }
    }
}
