using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGestionDeFeria
{
    public partial class FParticipantes : Form
    {
        public FParticipantes()
        {
            InitializeComponent();
            CargarEmprendimientos();
        }
        //=====================================================================================
        private string rutaFotoParticipante = string.Empty;
        //=====================================================================================
        private void CargarEmprendimientos()
        {
            try
            {
                CN_Emprendimiento objNegocio = new CN_Emprendimiento();
                List<Emprendimiento> lista = objNegocio.ListarEmprendimientos();

                cBoxSeleccionarERP.SelectedIndexChanged -= cBoxSeleccionarERP_SelectedIndexChanged;
                cBoxSeleccionarERP.DataSource = null;
                cBoxSeleccionarERP.Items.Clear();

                if (lista.Count > 0)
                {
                    cBoxSeleccionarERP.DisplayMember = "NombreEmprendimiento";
                    cBoxSeleccionarERP.ValueMember = "IdEmprendimiento";
                    cBoxSeleccionarERP.DataSource = lista;
                    cBoxSeleccionarERP.SelectedIndex = -1;
                }

                // Se conecta el evento
                cBoxSeleccionarERP.SelectedIndexChanged += cBoxSeleccionarERP_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar emprendimientos: " + ex.Message);
            }
        }
        //=====================================================================================
        private void cBoxSeleccionarERP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxSeleccionarERP.SelectedIndex != -1 && cBoxSeleccionarERP.SelectedValue != null)
            {
                int idEmprendimiento;
                if (int.TryParse(cBoxSeleccionarERP.SelectedValue.ToString(), out idEmprendimiento))
                {
                    CargarParticipantes();
                }
            }
        }
        //=====================================================================================
        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            try
            {
                if (cBoxSeleccionarERP.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un emprendimiento");
                    return;
                }

                Participante objParticipante = new Participante
                {
                    IdEmprendimiento = Convert.ToInt32(cBoxSeleccionarERP.SelectedValue),
                    Nombres = txtNombresP.Text.Trim(),
                    Apellidos = txtApellidosP.Text.Trim(),
                    Cargo = cBoxCargo.SelectedItem?.ToString() ?? string.Empty,
                    RutaFoto = rutaFotoParticipante
                };

                CN_Participante objNegocio = new CN_Participante();
                string mensaje = string.Empty;

                bool respuesta = objNegocio.RegistrarParticipante(objParticipante, out mensaje);

                if (respuesta)
                {
                    MessageBox.Show("Participante registrado correctamente");
                    LimpiarCampos();
                    CargarParticipantes();
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
        private void CargarParticipantes()
        {
            try
            {
                if (cBoxSeleccionarERP.SelectedIndex != -1 && cBoxSeleccionarERP.SelectedValue != null)
                {
                    int id;
                    if (int.TryParse(cBoxSeleccionarERP.SelectedValue.ToString(), out id))
                    {
                        CN_Participante objNegocio = new CN_Participante();
                        dVParticipante.AutoGenerateColumns = false;
                        dVParticipante.DataSource = objNegocio.ListarParticipantesPorEmprendimiento(id);
                    }
                   
                    if (dVParticipante.Columns["IdParticipante"] != null)
                    {
                        dVParticipante.Columns["IdParticipante"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //=====================================================================================
        private void btnArchivo2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string carpetaDestino = Path.Combine(Application.StartupPath, "FotosParticipantes");

                    if (!Directory.Exists(carpetaDestino))
                    {
                        Directory.CreateDirectory(carpetaDestino);
                    }

                    string nombreArchivo = $"{DateTime.Now.Ticks}_{Path.GetFileName(ofd.FileName)}";
                    rutaFotoParticipante = Path.Combine(carpetaDestino, nombreArchivo);
                    File.Copy(ofd.FileName, rutaFotoParticipante, true);

                    MessageBox.Show("Foto seleccionada correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //=====================================================================================
        private void LimpiarCampos()
        {
            txtNombresP.Clear();
            txtApellidosP.Clear();
            cBoxCargo.SelectedIndex = -1;
            rutaFotoParticipante = string.Empty;
        }
        //===================================================================================
        private void FParticipantes_Load(object sender, EventArgs e)
        {
            panelSupRegistro.BackColor = Color.FromArgb(21, 113, 59);
            btnArchivo2.FlatStyle = FlatStyle.Flat;
            btnArchivo2.FlatAppearance.BorderSize = 0;
            btnArchivo2.FlatAppearance.BorderSize = 0;
        }
        //==================================================================================
        private void dVParticipante_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dVParticipante.Rows[e.RowIndex];
            if (fila.Cells["IdParticipante"].Value == null) return;

            int id = Convert.ToInt32(fila.Cells["IdParticipante"].Value);
            string nombre = fila.Cells["Nombre"].Value?.ToString() ?? "";
            string apellido = fila.Cells["Apellido"].Value?.ToString() ?? "";
            string cargo = fila.Cells["Cargo"].Value?.ToString() ?? "";

            CN_Participante objNegocio = new CN_Participante();
            string mensaje;

            bool exito = objNegocio.EditarParticipante(id, nombre, apellido, cargo, out mensaje);

            if (!exito)
            {
                MessageBox.Show("Error al guardar: " + mensaje);
                CargarParticipantes();
            }
        }
    }
}
