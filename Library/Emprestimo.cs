﻿namespace Library
{
    public class Emprestimo
    {
        //Victor Rafael da Silva
        public Leitor Origem {  get; set; }
        public Leitor Destino { get; set; }
        public Exemplar Item { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }

    }
}
