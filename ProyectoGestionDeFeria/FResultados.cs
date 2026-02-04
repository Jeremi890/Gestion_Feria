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
                // 1. VALIDACIÓN
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
                // 2. VALIDACIÓN DE DUPLICADOS
                CN_Resultado objNegocio = new CN_Resultado();
                string categoriaActual = cBoxCategoriaPremio.Text;
                int nuevaPosicion = cBoxPosicionGanador.SelectedIndex + 1;
                int idEmprendimiento = Convert.ToInt32(cBoxEmprendimientoGanador.SelectedValue);

                DataTable existentes = objNegocio.ListarResultados(categoriaActual);

                foreach (DataRow fila in existentes.Rows)
                {
                    // A) Se verifica que el emprendimiento no tenga ya una premiación
                    if (Convert.ToInt32(fila["IdEmprendimiento"]) == idEmprendimiento)
                    {
                        MessageBox.Show($"El emprendimiento '{fila["NombreEmprendimiento"]}' ya tiene un premio en esta categoría.");
                        return;
                    }

                    // B) Se valida que una posición no esté ya registrada
                    if (Convert.ToInt32(fila["Posicion"]) == nuevaPosicion)
                    {
                        MessageBox.Show($"La posición {nuevaPosicion} ya está ocupada por '{fila["NombreEmprendimiento"]}'.");
                        return;
                    }
                }
                // 3. CREACIÓN Y GUARDADO

                Resultado objResultado = new Resultado();

                objResultado.IdEmprendimiento = idEmprendimiento;
                objResultado.CategoriaPremio = categoriaActual;
                objResultado.Posicion = nuevaPosicion;

                string mensaje = string.Empty;
                bool respuesta = objNegocio.RegistrarResultado(objResultado, out mensaje);

                if (respuesta)
                {
                    MessageBox.Show("Resultado registrado correctamente");

                    CargarResultados();
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
                string filtro = cBoxCategoriaPremio.Text;

                dVPremioRegistrado.DataSource = objNegocio.ListarResultados(filtro);
                dVPremioRegistrado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // 1. Ocultar columnas que no queremos ver (IDs)
                if (dVPremioRegistrado.Columns["IdResultado"] != null)
                    dVPremioRegistrado.Columns["IdResultado"].Visible = false;

                if (dVPremioRegistrado.Columns["IdEmprendimiento"] != null)
                    dVPremioRegistrado.Columns["IdEmprendimiento"].Visible = false;

                // 2. Agregar botón de eliminar (Solo si no existe ya)
                if (dVPremioRegistrado.Columns["btnEliminar"] == null)
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.Name = "btnEliminar";
                    btn.HeaderText = "Acción";
                    btn.Text = "Eliminar";
                    btn.UseColumnTextForButtonValue = true; // Para que diga "Eliminar"
                    btn.DefaultCellStyle.BackColor = Color.IndianRed;
                    btn.DefaultCellStyle.ForeColor = Color.White;
                    dVPremioRegistrado.Columns.Add(btn);
                }
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
        //==================================================================================
        private void cBoxCategoriaPremio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarResultados();
        }
        //===================================================================================
        private void dVPremioRegistrado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dVPremioRegistrado.Columns[e.ColumnIndex].Name == "btnEliminar" && e.RowIndex >= 0)
            {
                DialogResult pregunta = MessageBox.Show("¿Desea eliminar este registro de premiación?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (pregunta == DialogResult.Yes)
                {
                    int idResultado = Convert.ToInt32(dVPremioRegistrado.Rows[e.RowIndex].Cells["IdResultado"].Value);
                    CN_Resultado objNegocio = new CN_Resultado();
                    string mensaje = string.Empty;

                    if (objNegocio.EliminarResultado(idResultado, out mensaje))
                    {
                        CargarResultados();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar: " + mensaje);
                    }
                }
    }
    }
    }
}
