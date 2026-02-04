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
    public partial class FDetalleEmprendimiento : Form
    {
        private int _idEmprendimiento;
        public FDetalleEmprendimiento(int idRecibido)
        {
            InitializeComponent();
            _idEmprendimiento = idRecibido;
        }
        //================================================================================
        private void FDetalleEmprendimiento_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        //=============================================================================
        private void CargarDatos()
        {
            CN_Emprendimiento objNegocioEmp = new CN_Emprendimiento();
            var emp = objNegocioEmp.ListarEmprendimientos()
                        .FirstOrDefault(x => x.IdEmprendimiento == _idEmprendimiento);

            if (emp != null)
            {
                lblNombre.Text = emp.NombreEmprendimiento;
                lblDescripcion.Text = emp.Descripcion;
                lblRubro.Text = emp.Rubro;
                lblFacultad.Text = emp.Facultad;

                string ruta = emp.RutaFoto;

                if (!string.IsNullOrEmpty(ruta) && System.IO.File.Exists(ruta))
                {
                    pBoxFoto.SizeMode = PictureBoxSizeMode.Zoom;
                    pBoxFoto.ImageLocation = ruta;
                }
                else
                {
                    pBoxFoto.Image = null;
                    pBoxFoto.BackColor = Color.LightGray;
                }
            }
            CN_Participante objNegocioPart = new CN_Participante();
            dgvParticipantes.DataSource = objNegocioPart.ListarParticipantesPorEmprendimiento(_idEmprendimiento);
        }

        //=============================================================================
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
