using CapaEntidades;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class FResultados : Form
    {
        public FResultados()
        {
            InitializeComponent();
            CargarEmprendimientos();
        }
        //=====================================================================================
        private void CargarEmprendimientos()
        {
            try
            {
                CN_Emprendimiento objNegocio = new CN_Emprendimiento();
                List<Emprendimiento> lista = objNegocio.ListarEmprendimientos();

                if (cBoxEmprendimientoGanador != null)
                {
                    cBoxEmprendimientoGanador.DataSource = null;
                    cBoxEmprendimientoGanador.Items.Clear();

                    if (lista.Count > 0)
                    {
                        cBoxEmprendimientoGanador.DisplayMember = "NombreEmprendimiento";
                        cBoxEmprendimientoGanador.ValueMember = "IdEmprendimiento";
                        cBoxEmprendimientoGanador.DataSource = lista;
                        cBoxEmprendimientoGanador.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //=====================================================================================
        private void btnRegistrarGanador_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. VALIDACIONES
                if (cBoxCategoriaPremio.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una Categoría.");
                    return;
                }
                if (cBoxEmprendimientoGanador.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un Emprendimiento.");
                    return;
                }
                if (cBoxPosicionGanador.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una Posición.");
                    return;
                }

                // 2. CREACIÓN DE OBJETO
                Resultado objResultado = new Resultado();

                // Validación del ID Emprendimiento
                if (cBoxEmprendimientoGanador.SelectedValue != null &&
                    int.TryParse(cBoxEmprendimientoGanador.SelectedValue.ToString(), out int idEmpre))
                {
                    objResultado.IdEmprendimiento = idEmpre;
                }
                else
                {
                    MessageBox.Show("Error al leer el emprendimiento seleccionado.");
                    return;
                }

                // Se Asigna Categoría
                objResultado.CategoriaPremio = cBoxCategoriaPremio.Text;
                objResultado.Posicion = cBoxPosicionGanador.SelectedIndex + 1;

                // 3. GUARDADO
                CN_Resultado objNegocio = new CN_Resultado();
                string mensaje = string.Empty;

                bool respuesta = objNegocio.RegistrarResultado(objResultado, out mensaje);

                if (respuesta)
                {
                    MessageBox.Show("Resultado registrado correctamente");
                    CargarResultados();

                    // Limpiar campos
                    cBoxEmprendimientoGanador.SelectedIndex = -1;
                    cBoxPosicionGanador.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }
        //=====================================================================================
        private void CargarResultados()
        {
            try
            {
                CN_Resultado objNegocio = new CN_Resultado();
                dVPremioRegistrado.DataSource = objNegocio.ListarResultados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //=====================================================================================
        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = $"Resultados_Feria_{DateTime.Now:yyyyMMdd}.pdf";
                saveFile.Filter = "PDF files (*.pdf)|*.pdf";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    // A) Creación de documento
                    Document doc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, new FileStream(saveFile.FileName, FileMode.Create));
                    doc.Open();

                    // B) Título
                    iTextSharp.text.Font tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18f);
                    Paragraph titulo = new Paragraph("Resultados de la Feria de Emprendimiento", tituloFont);
                    titulo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(titulo);
                    doc.Add(new Paragraph(" "));

                    // C) Se obtiene Datos
                    CN_Resultado objNegocio = new CN_Resultado();
                    DataTable resultados = objNegocio.ListarResultados();

                    // D) Creación de Tabla PDF
                    PdfPTable tabla = new PdfPTable(4);
                    tabla.WidthPercentage = 100f;

                    // Encabezados
                    tabla.AddCell("Categoría");
                    tabla.AddCell("Emprendimiento");
                    tabla.AddCell("Facultad");
                    tabla.AddCell("Posición");

                    // E) Filas
                    if (resultados != null && resultados.Rows.Count > 0)
                    {
                        foreach (DataRow row in resultados.Rows)
                        {
                            tabla.AddCell(row["categoriapremio"].ToString());
                            tabla.AddCell(row["nombreemprendimiento"].ToString());
                            tabla.AddCell(row["facultad"].ToString());
                            tabla.AddCell(row["posicion"].ToString());
                        }
                    }

                    doc.Add(tabla);
                    doc.Close();
                    MessageBox.Show("PDF exportado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
