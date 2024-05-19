namespace Library
{
     public class Funcionario : Pessoa
    {
        //Victor Rafael da Silva
        public int Cargo { get; set; }
        public decimal Salary { get; set; }
        public int CargaHoraria { get; set; }
        public string Funcao { get; set; }

        public Funcionario(string nome, DateTime nascimento, string cpf, string email, string telefone, int cargo, decimal salary, int cargaHorario, string funcao) : base(nome, nascimento, cpf, email, telefone)
        {
            Cargo = cargo;
            Salary = salary;
            CargaHoraria = cargaHorario;
            Funcao = funcao;
        }

        public void NovoLeitor(Leitor leitor)
        {

        }

        public void ExcluirLeitor(Leitor leitor)
        {

        }

        public void NovoFuncionario(Funcionario funcionario)
        {

        }

        public void EditarFuncionario(Funcionario funcionario)
        {

        }

        public void ExcluirFuncionario(Funcionario funcionario)
        {

        }

        public void ListaFuncionario(Funcionario funcionario)
        {

        }

        public void NovoExemplar(Exemplar exemplar)
        {

        }

        public void EditaExemplar(Exemplar exemplar)
        {

        }

        public void ExcluiExemplar(Exemplar exemplar)
        {

        }

        public void ListaExemplar(Exemplar exemplar)
        {

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

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
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

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
