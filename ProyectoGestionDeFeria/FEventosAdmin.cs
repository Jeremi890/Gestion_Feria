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
            if (PanelDesarrollo.Controls.Count > 0)
            {
                PanelDesarrollo.Controls.Clear();
            }

            // Configura el formulario hijo
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            // Agrega y muestra el formulario
            PanelDesarrollo.Controls.Add(formularioHijo);
            PanelDesarrollo.Tag = formularioHijo;
            formularioHijo.Show();
        }

    }
}
