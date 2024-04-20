namespace Library
{
    public class Leitor : Pessoa
    {
        public List<Exemplar> ExemplaresLeitor { get; set; }
        public List<Emprestimo> EmprestimosLeitor { get; set; }
        public string Tipo { get; set; }

        public Leitor(String nome, DateTime nascimento, string cpf, string email, string telefone,List<Exemplar> exemplaresLeitor, List<Emprestimo> emprestimosLeitor, string tipo) : base(nome, nascimento, cpf, email, telefone)
        {
            ExemplaresLeitor = exemplaresLeitor;
            EmprestimosLeitor = emprestimosLeitor;
            Tipo = tipo;
        }

        public bool EmprestarItem(Exemplar exemplar, Leitor destino)
        {
            return false;
        }

        public bool DevolucaoItem(Exemplar exemplar, Leitor destino)
        {
            return false;
        }

        public bool DoaExemplar(Exemplar exemplar, Leitor destino)
        {
            return false;
        }

        public bool TrocaExemplar(Exemplar exemplarVai, Leitor leitorVai, Exemplar exemplarVem, Leitor leitorVem)
        {
            return false;
        }

        public override void AdicionarExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            throw new NotImplementedException();
        }

        public override void EditaExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            throw new NotImplementedException();
        }

        public override void EditaLeitor(Leitor leitor)
        {
            throw new NotImplementedException();
        }

        public override void ListaExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            throw new NotImplementedException();
        }

        public override void ListarLeitor(Leitor leitor)
        {
            throw new NotImplementedException();
        }

        public override void RemoverExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            throw new NotImplementedException();
        }
    }

}
