namespace Library
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        protected Pessoa(string nome, DateTime nascimento, string cpf, string email, string telefone)
        {
            Nome = nome;
            Nascimento = nascimento;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
        }

        public abstract void ListarLeitor(Leitor leitor);
        public abstract void EditaLeitor(Leitor leitor);
        public abstract void AdicionarExemplarLeitor(Exemplar exemplar, Leitor leitor);
        public abstract void RemoverExemplarLeitor(Exemplar exemplar, Leitor leitor);
        public abstract void EditaExemplarLeitor(Exemplar exemplar, Leitor leitor);
        public abstract void ListaExemplarLeitor(Exemplar exemplar, Leitor leitor);
    }
}
