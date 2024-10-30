using OxyPlot;
using OxyPlot.Series;

namespace GraficaFuncionesMath
{
    public partial class FrmGraficadora : Form
    {
        private EcuacionesSegundoGrado? ecuaciones;

        public FrmGraficadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Calcular 
            string aText = txtCoeA.Text;
            string bText = txtCoeB.Text;
            string cText = txtCoeC.Text;
            double a;
            double b;
            double c;
            double[] resultado;
            var plotModel = new PlotModel() { Title = "Gráfica de Ecuación Cuadrática", TextColor = OxyColors.White };
            var serie = new LineSeries() { Title = "Ecuación", TextColor = OxyColors.White };

            if (string.IsNullOrEmpty(aText) || string.IsNullOrEmpty(bText) || string.IsNullOrEmpty(cText))
            {
                MessageBox.Show("La ecuación no está completa, ingrese todos los coeficientes. Incluido el 1 o 0", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(aText, out a))
            {
                MessageBox.Show("Ha ocurrido un error con el coeficiente A. Intente nuevamente", "A", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(bText, out b))
            {
                MessageBox.Show("Ha ocurrido un error con el coeficiente B. Intente nuevamente", "B", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(cText, out c))
            {
                MessageBox.Show("Ha ocurrido un error con el coeficiente C. Intente nuevamente", "C", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (a == 0)
            {
                MessageBox.Show("El coeficiente A no puede ser 0 (cero) en una ecuación de segundo grado", "Coeficiente A Ecuación Segundo Grado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ecuaciones = null;
            ecuaciones = new EcuacionesSegundoGrado(a, b, c);
            resultado = ecuaciones.Calcular();

            if (ecuaciones.Imaginaria())
            {
                lblResultadoText.Text = $"Raíces Imaginarias: \nx1 = {resultado[0]} + {resultado[1]}i \nx2= {resultado[0]} - {resultado[1]}i";
            }
            else
            {
                lblResultadoText.Text = $"Raíces Reales: \nx1 = {resultado[0]} \nx2= {resultado[1]}";
                var puntoRaiz1 = new ScatterPoint(resultado[0], 0);
                var puntoRaiz2 = new ScatterPoint(resultado[1], 0);
                plotModel.Series.Add(new ScatterSeries
                {
                    Title = "Raíces",
                    TextColor = OxyColors.White,
                    MarkerType = MarkerType.Circle,
                    ItemsSource = new List<ScatterPoint> { puntoRaiz1, puntoRaiz2 }
                });
            }

            var puntos = ecuaciones.ObtenerPuntosGrafica();

            foreach (var punto in puntos)
            {
                serie.Points.Add(punto);
            }
            plotModel.Series.Add(serie);
            plotViewGrafica.Model = plotModel;
        }

        private void btnLimpia_Click(object sender, EventArgs e)
        {
            txtCoeA.Text = string.Empty;
            txtCoeB.Text = string.Empty;
            txtCoeC.Text = string.Empty;
            lblResultadoText.Text = string.Empty;
            plotViewGrafica.Model = null;
        }

        public static void NumeroDecimal(TextBox cajaDeTexto, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) || Char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == '.' && !cajaDeTexto.Text.Contains('.'))
            {
                return;
            }
            if (e.KeyChar == '-' && !cajaDeTexto.Text.Contains('-'))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtCoeA_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumeroDecimal(txtCoeA, e);
        }

        private void txtCoeB_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumeroDecimal(txtCoeB, e);
        }

        private void txtCoeC_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumeroDecimal(txtCoeC, e);
        }
    }
}
