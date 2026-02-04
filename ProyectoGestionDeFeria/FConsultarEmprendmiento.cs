using CapaEntidades;
using CapaNegocio;
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
    public partial class FConsultarEmprendmiento : Form
    {
        public FConsultarEmprendmiento()
        {
            InitializeComponent();
        }
        //================================================================================
        private void FConsultarEmprendimiento_Load(object sender, EventArgs e)
        {
            CargarEmprendimientos();
        }
        //=======================================================================================
        private void CargarEmprendimientos(string filtro = "")
        {
            flowPanelContenedor.Controls.Clear(); // Limpiamos lo anterior

            CN_Emprendimiento objNegocio = new CN_Emprendimiento();
            List<Emprendimiento> lista;

            if (string.IsNullOrEmpty(filtro))
                lista = objNegocio.ListarEmprendimientos();
            else
                lista = objNegocio.BuscarEmprendimiento(filtro);

            // Por cada emprendimiento, creamos una tarjeta visual
            foreach (var emp in lista)
            {
                Panel tarjeta = CrearTarjetaVisual(emp);
                flowPanelContenedor.Controls.Add(tarjeta);
            }
        }

        //=======================================================================================
        private Panel CrearTarjetaVisual(Emprendimiento emp)
        {
            // A) El Contenedor
            Panel panelCard = new Panel();
            panelCard.Size = new Size(750, 160);
            panelCard.BackColor = Color.White;
            panelCard.Margin = new Padding(10);
            panelCard.BorderStyle = BorderStyle.FixedSingle;

            // B) Etiqueta de Rubro
            Label lblRubro = new Label();
            lblRubro.Text = emp.Rubro;
            lblRubro.AutoSize = false;
            lblRubro.Size = new Size(120, 30);
            lblRubro.Location = new Point(600, 20);
            lblRubro.TextAlign = ContentAlignment.MiddleCenter;
            lblRubro.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblRubro.ForeColor = Color.White;
            // Colores por cada rubro
            if (emp.Rubro == "Tecnología") lblRubro.BackColor = Color.DodgerBlue;
            else if (emp.Rubro == "Gastronomía") lblRubro.BackColor = Color.Orange;
            else lblRubro.BackColor = Color.Gray;

            // C) Nombre del Emprendimiento
            Label lblTitulo = new Label();
            lblTitulo.Text = "" + emp.NombreEmprendimiento;
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(64, 64, 64);

            // D) Facultad
            Label lblFacultad = new Label();
            lblFacultad.Text = "Facultad: " + emp.Facultad;
            lblFacultad.Location = new Point(25, 55);
            lblFacultad.AutoSize = true;
            lblFacultad.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblFacultad.ForeColor = Color.Gray;

            // E) Descripción 
            Label lblDesc = new Label();
            lblDesc.Text = emp.Descripcion.Length > 150 ? emp.Descripcion.Substring(0, 150) + "..." : emp.Descripcion;
            lblDesc.Location = new Point(25, 85);
            lblDesc.Size = new Size(600, 40); 
            lblDesc.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblDesc.ForeColor = Color.DimGray;

            // F) Botón
            LinkLabel linkDetalle = new LinkLabel();
            linkDetalle.Text = "👁 Ver más detalles →";
            linkDetalle.Location = new Point(25, 130);
            linkDetalle.AutoSize = true;
            linkDetalle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            linkDetalle.LinkColor = Color.RoyalBlue;

            // Evento al dar clic en ver más
            linkDetalle.Click += (sender, e) => {
                AbrirDetalle(emp.IdEmprendimiento);
            };

            panelCard.Controls.Add(lblRubro);
            panelCard.Controls.Add(lblTitulo);
            panelCard.Controls.Add(lblFacultad);
            panelCard.Controls.Add(lblDesc);
            panelCard.Controls.Add(linkDetalle);

            return panelCard;
        }

        //=======================================================================================

        private void btnBuscarL_Click(object sender, EventArgs e)
        {
            CargarEmprendimientos(txtFEmprendimiento.Text.Trim());
        }
        //=======================================================================================
        private void AbrirDetalle(int idEmprendimiento)
        {
            // Llamado al nuevo formulario
           //  MessageBox.Show("Abriendo detalles del ID: " + idEmprendimiento);
            
            FDetalleEmprendimiento formDetalle = new FDetalleEmprendimiento(idEmprendimiento);
            formDetalle.ShowDialog();
            
        }
    }
}
