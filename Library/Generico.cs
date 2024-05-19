namespace Library
{
    internal class Generico : Exemplar
    {
        //Victor Rafael da Silva
        public int Tipo { get; set; }

        public Generico(string titulo, string subTitulo, string escritor, string editora, int anoPublicacao,string genero, int status, int tipo) : base(titulo, subTitulo, escritor, editora, anoPublicacao, genero, status)
        {
            Tipo = tipo;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
