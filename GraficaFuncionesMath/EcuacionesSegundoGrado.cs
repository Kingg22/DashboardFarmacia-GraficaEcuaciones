using OxyPlot;

namespace GraficaFuncionesMath
{
    internal class EcuacionesSegundoGrado
    {
        public double CoeficienteA {  get; set; }
        public double CoeficienteB { get; set; }
        public double CoeficienteC { get; set; }

        public EcuacionesSegundoGrado()
        {
            this.CoeficienteA = 0;
            this.CoeficienteB = 0;
            this.CoeficienteC = 0;
        }

        public EcuacionesSegundoGrado(double A,  double B, double C)
        {
            this.CoeficienteA = A;
            this.CoeficienteB = B;
            this.CoeficienteC = C;
        }

        // Arreglo de 2 posiciones donde [0] es respuesta A o Parte real y [1] es respuesta B o Parte imaginaria
        public double[] Calcular()
        {
            double determinante = this.CalcularDiscriminante();
            double respuestaA;
            double respuestaB;

            if (determinante > 0)
            {
                // Raíces reales distintas
                double raizDiscriminada = Math.Sqrt(determinante);
                respuestaA = (-this.CoeficienteB + raizDiscriminada) / (2 * this.CoeficienteA);
                respuestaB = (-this.CoeficienteB - raizDiscriminada) / (2 * this.CoeficienteA);
            } else if (determinante == 0)
            {
                // Raíz real doble
                respuestaA = respuestaB = -this.CoeficienteB / (2 * this.CoeficienteA);
            } else
            {
                // Raíces imaginarias
                // Parte real será respuesta A
                respuestaA = -this.CoeficienteB / (2 * this.CoeficienteA);
                // Parte imaginaria será respuesta B
                respuestaB = Math.Sqrt(-this.CalcularDiscriminante()) / (2 * this.CoeficienteA);
            }
            return [respuestaA, respuestaB];
        }

        // Basado en esto se debe determinar cómo se utilizará la respuesta generada por Calcular()
        public bool Imaginaria()
        {
            return this.CalcularDiscriminante() < 0;
        }

        // De la ecuación general es b² - 4ac
        private double CalcularDiscriminante()
        {
            return (double) Math.Pow(this.CoeficienteB , 2) - 4 * this.CoeficienteA * this.CoeficienteC;
        }

        public List<DataPoint> ObtenerPuntosGrafica(double inicio = -10, double fin = 10, double paso = 0.1)
        {
            var puntos = new List<DataPoint>();
            for (double x = inicio; x <= fin; x += paso)
            {
                double y = (this.CoeficienteA * x * x) + (this.CoeficienteB * x) + this.CoeficienteC;
                puntos.Add(new DataPoint(x, y));
            }
            return puntos;
        }
    }
}
