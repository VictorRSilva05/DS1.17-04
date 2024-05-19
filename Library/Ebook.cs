﻿namespace Library
{
    internal class Ebook : Livro
    {
        //Victor Rafael da Silva
        public string Formato { get; set; }
        public decimal Tamanho { get; set; }
        public string Url { get; set; }

        public Ebook(string titulo, string subTitulo, string escritor, string editora, int anoPublicacao, string genero, int status, int paginas, string tipoCapa, string isbn,string formato, decimal tamanho, string url) : base(titulo, subTitulo, escritor, editora, anoPublicacao, genero, status, paginas, tipoCapa, isbn)
        {
            Formato = formato;
            Tamanho = tamanho;
            Url = url;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
