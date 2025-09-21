namespace CadastroPessoas
{
    internal class Program
    {
        enum Opcao { Cadastrar = 1, Listar, Deletar, Sair }
        static void Main(string[] args)
        {
            Console.WriteLine("---- Cadastro de Pessoas ----");
            List<Pessoa> pessoas = new List<Pessoa>();
            int opcao;

            do
            {
                Console.WriteLine("Selecione uma opção abaixo:");
                Console.WriteLine("[1] - Cadastrar Pessoa\n[2] - Listar Pessoas\n[3] - Deletar Pessoa\n[4] - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                Opcao escolha = (Opcao)opcao;

                switch (escolha)
                {
                    case Opcao.Cadastrar:
                        Console.WriteLine("Insira o ID da pessoa: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o nome da pessoa: ");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Digite a idade:");
                        int idade = Convert.ToInt32(Console.ReadLine());

                        Pessoa pessoa = new Pessoa(id, nome, idade);
                        pessoas.Add(pessoa);
                        break;
                    case Opcao.Listar:
                        Console.WriteLine("=== Lista de Pessoas ===");

                        foreach (Pessoa p in pessoas)
                        {
                            Console.WriteLine($"ID: {p.Id}, Nome: {p.Nome}, Idade: {p.Idade}");
                        }
                        break;
                    case Opcao.Deletar:
                        Console.WriteLine("Insira o ID da pessoa que deseja deletar: ");
                        int idDeletar = Convert.ToInt32(Console.ReadLine());
                        Pessoa pessoaDeletar = pessoas.Find(p => p.Id == idDeletar);
                        if (pessoaDeletar != null)
                        {
                            pessoas.Remove(pessoaDeletar);
                            Console.WriteLine("Pessoa deletada com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Pessoa não encontrada.");
                        }

                        break;
                    case Opcao.Sair:
                        Console.WriteLine("Encerrando Sistema...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
            while (opcao != (int)Opcao.Sair);
        }
    }
}