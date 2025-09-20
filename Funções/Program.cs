namespace Funções
{
    class Program
    {
        static void Main(string[] args)
        {
            ExibirMensagem();
            GerarPreco(100);
        }
        static void ExibirMensagem()
        {
            Console.WriteLine("Estou usando funções.");
            Console.WriteLine("Bem vindo!");
        }
        static void GerarPreco(int preco)
        {
            int precoAbs = Math.Abs(preco); // Invertendo o sinal do preço se negativo
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Preço base: " + precoAbs);
            Console.WriteLine("Preço Final: " + valorFinal);
        }
    }
}