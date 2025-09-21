using System.Diagnostics;

namespace Enum
{
    class Program
    {
        // Cria um enum chamado Carro, em que cada carro representa um valor inteiro, iniciando em 0 no padrão
        enum Carro { Ford, Fiat, Honda, Toyota, Chevrolet }

        // Criando um menu principal
        enum Opcao { Criar = 1, Deletar, Editar, Listar }
        static void Main(string[] args)
        {
            // Definindo uma variável do tipo Carro e atribuindo o valor Ford
            Carro meuCarro = Carro.Ford;
            Console.WriteLine($"Meu carro: {meuCarro}");
            // Convertendo o valor do enum para inteiro
            Console.WriteLine("Valor inteiro do carro: " + (int)meuCarro);
            // Convertendo o valor inteiro para o enum
            Console.WriteLine("Carro do valor 3: " + (Carro)3);

            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1- Criar\n2- Deletar\n3- Editar\n4- Listar");
            int index = int.Parse(Console.ReadLine());

            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você selecionou a opção Criar");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Você selecionou a opção Deletar");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Você selecionou a opção Editar");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Você selecionou a opção Listar");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}