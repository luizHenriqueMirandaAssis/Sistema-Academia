using System;
using System.Collections.Generic;

namespace ObjetoTransferencia
{
    public class Treinamento
    {
        public int IDTreinamento { get; set; }
        public TipoTreinamento TipoTreinamento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public Aluno Aluno { get; set; }

    }

    public class ListaTreinamento : List<Treinamento>
    {

    }
}
