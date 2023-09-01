namespace MenuCalc.Models
{

    public class Menu
    {
        private Calculadora calculadora;

        public Menu(Calculadora calculadora)
        {
            this.calculadora = calculadora;
        }
        public void MenuCalculadora()
        {

            Console.WriteLine("Calculadora Simples no Console");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Sair");
            Console.Write("Digite o número da operação desejada: ");

           
            string escolha = Console.ReadLine();

            if (escolha == "5")
            {
                Console.Clear();
                Console.WriteLine("Tchau");
                Environment.Exit(0);
                
            }

            double num1 = calculadora.EscolhaNumero();
            double num2 = calculadora.EscolhaNumero();

            switch (escolha)
            {
                case "1":

                    calculadora.Soma(num1, num2);

                    break;

                case "2":
                    calculadora.Subtracao(num1, num2);

                    break;

                case "3":
                    calculadora.Multiplicacao(num1, num2);

                    break;

                case "4":
                    calculadora.Divisao(num1, num2);

                    break;

                default:
                    Console.WriteLine("Opção inválida. Pressione Enter para continuar.");

                    break;
            }
            Console.ReadLine();
            Console.Clear();
        }

    }
}
