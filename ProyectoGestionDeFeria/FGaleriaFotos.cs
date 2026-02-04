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
using System.IO;

namespace ProyectoGestionDeFeria
{
    public partial class FGaleriaFotos : Form
    {
        private Dictionary<int, int> likesSimulados = new Dictionary<int, int>();

        public FGaleriaFotos()
        {
            InitializeComponent();
            CargarGaleria();
        }
        
        //=====================================================================================
        private void CargarGaleria(string filtro = "")
        {
            flowPanelGaleria.Controls.Clear();

            CN_Emprendimiento objNegocio = new CN_Emprendimiento();
            List<Emprendimiento> lista;
            if (string.IsNullOrEmpty(filtro))
                lista = objNegocio.ListarEmprendimientos();
            else
                lista = objNegocio.BuscarEmprendimiento(filtro);

            foreach (var emp in lista)
            {
                if (!likesSimulados.ContainsKey(emp.IdEmprendimiento))
                    likesSimulados.Add(emp.IdEmprendimiento, 0);

                Panel tarjeta = CrearTarjetaGaleria(emp);
                flowPanelGaleria.Controls.Add(tarjeta);
            }

            if (flowPanelGaleria.Controls.Count == 0)
            {
                Label lbl = new Label
                {
                    Text = "No hay imágenes disponibles",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12),
                    ForeColor = Color.Gray
                };
                flowPanelGaleria.Controls.Add(lbl);
            }
        }
        //======================================================================================
        private Panel CrearTarjetaGaleria(Emprendimiento emp)
        {
            // A) EL CONTENEDOR
            Panel panelCard = new Panel();
            panelCard.Size = new Size(260, 360);
            panelCard.BackColor = Color.White;
            panelCard.Margin = new Padding(15);

            // B) FOTO
            PictureBox pBox = new PictureBox();
            pBox.Size = new Size(260, 180);
            pBox.Dock = DockStyle.Top;
            pBox.SizeMode = PictureBoxSizeMode.Zoom;
            pBox.BackColor = Color.WhiteSmoke;

            // Se carga la imagen
            string ruta = emp.RutaFoto;
            if (!string.IsNullOrEmpty(ruta) && System.IO.File.Exists(ruta))
            {
                pBox.ImageLocation = ruta;
            }
            else
            {
                pBox.Image = null;
                pBox.BackColor = Color.LightGray; 
            }

            // C) DESCRIPCION
            Panel panelInfo = new Panel();
            panelInfo.Dock = DockStyle.Fill;
            panelInfo.Padding = new Padding(10);

            // Título 
            Label lblTitulo = new Label();
            lblTitulo.Text = emp.NombreEmprendimiento;
            lblTitulo.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;

            // Rubro
            Label lblRubro = new Label();
            lblRubro.Text = emp.Rubro;
            lblRubro.AutoSize = false;
            lblRubro.Size = new Size(100, 25);
            lblRubro.TextAlign = ContentAlignment.MiddleCenter;
            lblRubro.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            lblRubro.ForeColor = Color.White;

            // Colores Rubro
            switch (emp.Rubro)
            {
                case "Tecnología": lblRubro.BackColor = Color.DodgerBlue; break;
                case "Gastronomía": lblRubro.BackColor = Color.Orange; break;
                default: lblRubro.BackColor = Color.MediumSeaGreen; break;
            }

            // Separa el rubro del título
            Panel pnlRubro = new Panel { Height = 35, Dock = DockStyle.Top };
            pnlRubro.Controls.Add(lblRubro);

            // D) BOTONES

            // Botón A: "Me Gusta"
            Button btnLike = new Button();
            btnLike.Text = $"❤ {likesSimulados[emp.IdEmprendimiento]}";
            btnLike.FlatStyle = FlatStyle.Flat;
            btnLike.FlatAppearance.BorderSize = 0;
            btnLike.ForeColor = Color.Crimson;
            btnLike.Location = new Point(5, 120);
            btnLike.Size = new Size(80, 30);

            btnLike.Click += (s, e) => {
                likesSimulados[emp.IdEmprendimiento]++;
                btnLike.Text = $"❤ {likesSimulados[emp.IdEmprendimiento]}";
            };

            // Botón B: "Comentar / Ver Foto"
            Button btnComentar = new Button();
            btnComentar.Text = "💬 Comentar";
            btnComentar.BackColor = Color.RoyalBlue;
            btnComentar.ForeColor = Color.White;
            btnComentar.FlatStyle = FlatStyle.Flat;
            btnComentar.Location = new Point(140, 120);
            btnComentar.Size = new Size(110, 30);
//------------------------------------------------------------------------------------
            btnComentar.Click += (s, e) => {
                // Nueva tarjeta con datos de la tarjeta
                FVisualizarFoto formComentarios = new FVisualizarFoto(
                    emp.IdEmprendimiento,
                    emp.NombreEmprendimiento,
                    emp.RutaFoto
                );
                formComentarios.ShowDialog();
            };

            // Se crea la tarjeta junto a sus controles
            panelInfo.Controls.Add(pnlRubro); 
            panelInfo.Controls.Add(lblTitulo); 

            // Nota: Al usar Dock=Top, el último agregado queda arriba. 
            // Para eso usamos Location absoluta para los botones
            panelInfo.Controls.Add(btnLike);
            panelInfo.Controls.Add(btnComentar);

            panelCard.Controls.Add(panelInfo);
            panelCard.Controls.Add(pBox);

            return panelCard;
        }
    }
}

