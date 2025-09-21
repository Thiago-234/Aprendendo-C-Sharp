namespace CadastroPessoas
{
    internal class Pessoa
    {
        public int Id;
        public string Nome;
        public int Idade;

        public Pessoa(int id, string nome, int idade)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
        }
    }
}