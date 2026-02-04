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
    public partial class FModuloAdministrador : Form
    {
        public FModuloAdministrador()
        {
            InitializeComponent();
            ContenedorArchivoC1.Padding = new Padding(0);
        }
        private string rutaFotoEmprendimiento = string.Empty;
        //=====================================================================================
        private void btnArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                ofd.Title = "Seleccionar foto del emprendimiento";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string carpetaDestino = Path.Combine(Application.StartupPath, "FotosEmprendimientos");

                    if (!Directory.Exists(carpetaDestino))
                    {
                        Directory.CreateDirectory(carpetaDestino);
                    }

                    string nombreArchivo = $"{DateTime.Now.Ticks}_{Path.GetFileName(ofd.FileName)}";
                    string rutaCompleta = Path.Combine(carpetaDestino, nombreArchivo);

                    File.Copy(ofd.FileName, rutaCompleta, true);
                    rutaFotoEmprendimiento = rutaCompleta;

                    MessageBox.Show("Foto seleccionada correctamente", "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar archivo: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //=====================================================================================
        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            try
            {
                Emprendimiento objEmprendimiento = new Emprendimiento
                {
                    NombreEmprendimiento = txtNombreE.Text.Trim(),
                    Facultad = cBoxFacultadEmprendimiento.SelectedItem?.ToString() ?? string.Empty,
                    Rubro = cBoxRubro.SelectedItem?.ToString() ?? string.Empty,
                    Descripcion = txtDescripcion1.Text.Trim(),
                    RutaFoto = rutaFotoEmprendimiento
                };

                string mensaje = string.Empty;
                CN_Emprendimiento objNegocio = new CN_Emprendimiento();

                bool respuesta = objNegocio.RegistrarEmprendimiento(objEmprendimiento, out mensaje);

                if (respuesta)
                {
                    MessageBox.Show("Emprendimiento registrado correctamente", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(mensaje, "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //=====================================================================================
        private void LimpiarCampos()
        {
            txtNombreE.Clear();
            cBoxFacultadEmprendimiento.SelectedIndex = -1;
            cBoxRubro.SelectedIndex = -1;
            txtDescripcion1.Clear();
            rutaFotoEmprendimiento = string.Empty;
        }
        //================================================================================
        private void FModuloAdministrador_Load(object sender, EventArgs e)
        {
            panelRegistroEmp.BackColor = Color.FromArgb(21, 113, 59);
        }
        //================================================================================
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //================================================================================
        private void FModuloAdministrador_Load_1(object sender, EventArgs e)
        {
            btnArchivo.FlatAppearance.MouseOverBackColor = btnArchivo.BackColor;
            btnArchivo.FlatAppearance.MouseDownBackColor = btnArchivo.BackColor;
            btnArchivo.TabStop = false;
            btnArchivo.FlatStyle = FlatStyle.Flat;
            btnArchivo.FlatAppearance.BorderSize = 0;
        }
    }

}
