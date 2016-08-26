using System;
using System.Collections.Generic;

namespace ObjetoTransferencia
{
   public  class Pessoa
    {
       public int      IDPessoa            { get; set; }
        public string   Nome                { get; set; }
        public DateTime DataNascimento      { get; set; }
        public bool     Ativo               { get; set; }
        public bool    Sexo                { get; set; }
        public string   RG                  { get; set; }
        public string   CPF                 { get; set; }
        public string   TelefoneResidencial { get; set; }
        public string   TelefoneCelular     { get; set; }
        public string   Email               { get; set; }
        public string   Usuario             { get; set; }
        public string   Senha               { get; set; }
        public Endereco Endereco            { get; set; }

    }

    public class ListaPessoa : List<Pessoa>
    { 

    }

    }
