namespace ProyectoGestionDeFeria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //===========================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FEventosAdmin());
        } 
        //============================================================================
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FModuloEstudiante());
        }
        //===============================================================================
        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            PanelContenedor.Controls.Clear();

            // Configura el formulario hijo
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            // Agrega el formulario al panel
            PanelContenedor.Controls.Add(formularioHijo);
            PanelContenedor.Tag = formularioHijo;

            // Se muestra el formulario
            formularioHijo.Show();
        }

       
        

    }
}








