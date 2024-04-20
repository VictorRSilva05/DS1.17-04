namespace Library
{
    internal class Ebook : Livro
    {
        public string Formato { get; set; }
        public decimal Tamanho { get; set; }
        public string Url { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
