namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criar o array -> tipo[] nome = new tipo[tamanho];
            string[] frutas = new string[5] {
                "Banana",
                "Maçã",
                "Laranja",
                "Uva",
                "Abacaxi"
            };
            Console.WriteLine(frutas[0]); // Acessar o array -> nome[indice]
        }
    }
}