﻿using System.Collections.Generic;

namespace ObjetoTransferencia
{
    public class Endereco
    {
        public int IDEndereco { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public string Rua { get; set; }

    }

    public class ListaEndereco : List<Endereco>
    {

    }
}