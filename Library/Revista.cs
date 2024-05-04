namespace Library
{
    //Victor Rafael da Silva
    internal class Revista : Exemplar
    {
        public int Edicao {  get; set; }
        public int Paginas { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
