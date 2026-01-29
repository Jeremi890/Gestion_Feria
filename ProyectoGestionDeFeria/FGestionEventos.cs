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
    public partial class FGestionEventos : Form
    {
        public FGestionEventos()
        {
            InitializeComponent();
            CargarEmprendimientos();
        }
        private void FGestionEventos_Load(object sender, EventArgs e)
        {
            CargarEmprendimientos();
            CargarEventos();
        }
        //=====================================================================================
        private void CargarEmprendimientos()
        {
            try
            {
                CN_Emprendimiento objNegocio = new CN_Emprendimiento();
                List<Emprendimiento> lista = objNegocio.ListarEmprendimientos();

                ComboBox combo = cBoxGestionEmprendimiento;

                combo.DataSource = null;
                combo.Items.Clear();

                if (lista.Count > 0)
                {
                    combo.DisplayMember = "NombreEmprendimiento";
                    combo.ValueMember = "IdEmprendimiento";
                    combo.DataSource = lista;
                    combo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lista: " + ex.Message);
            }
        }

        //=====================================================================================
        private void btnRegistrarCronograma_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cBoxGestionEmprendimiento.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un emprendimiento");
                    return;
                }

                Evento objEvento = new Evento
                {
                    IdEmprendimiento = Convert.ToInt32(cBoxGestionEmprendimiento.SelectedValue),
                    FechaExposicion = dtDía.Value.Date,
                    HoraExposicion = dtHora.Value.TimeOfDay,

                    Ubicacion = txtUbicacion.Text.Trim(),
                    Orden = Convert.ToInt32(txtOrdenPresentacion.Text)
                };

                CN_Evento objNegocio = new CN_Evento();
                string mensaje = string.Empty;

                bool respuesta = objNegocio.RegistrarEvento(objEvento, out mensaje);

                if (respuesta)
                {
                    MessageBox.Show("Evento registrado correctamente");
                    LimpiarCampos();
                    CargarEventos();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //=====================================================================================
        private void CargarEventos()
        {
            try
            {
                CN_Evento objNegocio = new CN_Evento();
                dVCronogramaActual.DataSource = objNegocio.ListarEventos();
                dVCronogramaActual.Columns["EmprendimientoAsociado"].Visible = false;
                dVCronogramaActual.Columns["NombreDelEmprendimiento"].DisplayIndex = 0;
                dVCronogramaActual.Columns["NombreDelEmprendimiento"].HeaderText = "Emprendimiento";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //=====================================================================================
        private void LimpiarCampos()
        {
            cBoxGestionEmprendimiento.SelectedIndex = -1;
            txtUbicacion.Clear();
            txtOrdenPresentacion.Clear();
        }

        private void dtHora_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

