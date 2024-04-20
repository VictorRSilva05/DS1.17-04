namespace Library
{
    internal class Livro : Exemplar
    {
        public int Paginas { get; set; }
        public string TipoCapa { get; set; }
        public string Isbn { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
