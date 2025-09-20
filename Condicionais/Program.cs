namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verifica número (if else)
            int a = 2;
            int b = 3;

            if (a > b)
            {
                Console.WriteLine("A é maior que B (if)");
            }
            else if (a < b)
            {
                Console.WriteLine("A é menor que B (else if)");
            }
            else
            {
                Console.WriteLine("A é igual a B (else)");
            }

            // Cor favorita (switch case)
            Console.WriteLine("Qual sua cor favorita?");
            string corFavorita = Console.ReadLine();

            switch (corFavorita)
            {
                case "Vermelho":
                    Console.WriteLine("A cor favorita é Vermelho");
                    break;
                case "Verde":
                    Console.WriteLine("A cor favorita é Verde");
                    break;
                case "Azul":
                    Console.WriteLine("A cor favorita é Azul");
                    break;
                default:
                    Console.WriteLine("A cor favorita é outra");
                    break;
            }
            
            // Operadores lógicos
            // && -> Duas condições devem ser true
            // || -> Uma das condições deve ser true
            // ! -> Nega a condição (inverte o valor)
            int idade = 20;
            bool cnh = true;

            if (idade >= 18 && cnh)
            {
                Console.WriteLine("Pode dirigir");
            }
            else
            {
                Console.WriteLine("Não pode dirigir");
            }
        }
    }
}