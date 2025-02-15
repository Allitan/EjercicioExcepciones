
namespace EjercicioExcepciones
{
    public class Operaciones
    {
        public double Suma(double n1, double n2)
        {
            return n1 + n2;
        }
        public double Resta(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiplicacion(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Dividir(double n1, double n2)
        {
            if (n2 == 0)
            {
                throw new DivideByZeroException("No se divide entre 0");
            }
            return n1 / n2;
        }
    }
}
