namespace MenuCalc.Models
{
    public class Calculadora
    {

        public double EscolhaNumero()
        {
            Console.WriteLine("Digite um numero:");
            string resString = Console.ReadLine();

            double res = 0;
            if (Double.TryParse(resString, out res))
            {
                return res;
            }
            else
            {
                Console.WriteLine("Digite um numero valido");
                return EscolhaNumero();
            }
        }

        public void Soma(double a, double b)
        {

            double c = a + b;
            Console.WriteLine($"Sua Soma e {c}");

        }
        public void Subtracao(double a, double b)
        {
            double c = a - b;
            Console.WriteLine($"Sua Subtracao e {c}");
        }
        public void Divisao(double a, double b)
        {
            double c = a / b;
            Console.WriteLine($"Sua Divisao e {c}");
        }
        public void Multiplicacao(double a, double b)
        {
            double c = a * b;
            Console.WriteLine($"Sua Multiplicao e {c}");
        }
    }
}
