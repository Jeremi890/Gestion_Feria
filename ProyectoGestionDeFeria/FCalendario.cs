using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoGestionDeFeria
{
    public partial class FCalendario : Form
    {
        public FCalendario()
        {
            InitializeComponent();
        }
        private void FCalendario_Load(object sender, EventArgs e)
        {
            CargarEventos();
            CargarFiltroFacultades();
        }
        //================================================================================
        private void CargarFiltroFacultades()
        {
            cBoxFiltrarFacultad.Items.Add("Todas las facultades");
            cBoxFiltrarFacultad.Items.Add("Ingeniería");
            cBoxFiltrarFacultad.Items.Add("Gastronomía");
            cBoxFiltrarFacultad.Items.Add("Diseño");
            cBoxFiltrarFacultad.Items.Add("Ciencias");
            cBoxFiltrarFacultad.SelectedIndex = 0;
        }
        //================================================================================
        private void CargarEventos()
        {
            flowPanelEventos.Controls.Clear();
            CN_Evento objNegocio = new CN_Evento();
            List<Evento> listaEventos = objNegocio.ListarEventos();
            foreach (Evento evt in listaEventos)
            {
                DateTime fecha = evt.FechaExposicion;
                string facultad = evt.EmprendimientoAsociado.Facultad;
                if (cBoxFiltrarFacultad.SelectedIndex > 0 &&
                    cBoxFiltrarFacultad.SelectedItem.ToString() != facultad)
                    continue;

                Panel tarjeta = CrearTarjetaEvento(evt);
                flowPanelEventos.Controls.Add(tarjeta);
            }

            if (flowPanelEventos.Controls.Count == 0)

                // Validar si no hay coincidencias
                if (flowPanelEventos.Controls.Count == 0)
            {
                Label lblVacio = new Label();
                lblVacio.Text = "No hay eventos programados";
                lblVacio.AutoSize = true;
                lblVacio.Font = new Font("Segoe UI", 12, FontStyle.Italic);
                lblVacio.ForeColor = Color.Gray;
                lblVacio.Padding = new Padding(20);
                flowPanelEventos.Controls.Add(lblVacio);
            }
        }
        //========================================================================================
        private Panel CrearTarjetaEvento(Evento evt)
        {
            DateTime fecha = evt.FechaExposicion;
            string hora = evt.HoraExposicion.ToString(@"hh\:mm");

            // A) Contenedor de la Tarjeta
            Panel panelCard = new Panel();
            panelCard.Size = new Size(350, 160);
            panelCard.BackColor = Color.White;
            panelCard.BorderStyle = BorderStyle.FixedSingle;

            // Datos
            string nombreEmpre = evt.EmprendimientoAsociado.NombreEmprendimiento;
            string ubicacion = evt.Ubicacion;
            string facultad = evt.EmprendimientoAsociado.Facultad; 

            // B) Un Icono de Tachuela/Pin 
            Label lblIcon = new Label();
            lblIcon.Text = "📍";
            lblIcon.Font = new Font("Segoe UI", 14);
            lblIcon.Location = new Point(15, 15);
            lblIcon.AutoSize = true;

            // C) Fecha y Hora
            Label lblFecha = new Label();
            lblFecha.Text = $"{fecha.ToString("dd MMMM yyyy")} - {hora}";
            lblFecha.Location = new Point(45, 18); 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblFecha.ForeColor = Color.RoyalBlue;

            // D) Títulos de los Emprendimientos
            Label lblTitulo = new Label();
            lblTitulo.Text = nombreEmpre;
            lblTitulo.Location = new Point(15, 50);
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;

            // E) Ubicaciones
            Label lblStand = new Label();
            lblStand.Text = "Stand: " + ubicacion;
            lblStand.Location = new Point(15, 80);
            lblStand.AutoSize = true;
            lblStand.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblStand.ForeColor = Color.Gray;

            // F) Etiqueta de Categoría/Facultad
            Label lblTag = new Label();
            lblTag.Text = facultad; 
            lblTag.AutoSize = false;
            lblTag.Size = new Size(100, 25);
            lblTag.TextAlign = ContentAlignment.MiddleCenter;
            lblTag.Location = new Point(15, 115);
            lblTag.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            lblTag.ForeColor = Color.White;

            // Colores
            switch (facultad)
            {
                case "Ingeniería": case "Tecnología": lblTag.BackColor = Color.CornflowerBlue; break;
                case "Gastronomía": lblTag.BackColor = Color.Orange; break;
                case "Diseño": case "Textil": lblTag.BackColor = Color.Plum; break; // Moradito
                default: lblTag.BackColor = Color.MediumSeaGreen; break;
            }

            // Agregar todo al panel
            panelCard.Controls.Add(lblIcon);
            panelCard.Controls.Add(lblFecha);
            panelCard.Controls.Add(lblTitulo);
            panelCard.Controls.Add(lblStand);
            panelCard.Controls.Add(lblTag);

            return panelCard;
        }
        //========================================================================================
        private void btnBuscarCalendario_Click(object sender, EventArgs e)
        {
            CargarEventos();
        }


        //========================================================================================
        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
