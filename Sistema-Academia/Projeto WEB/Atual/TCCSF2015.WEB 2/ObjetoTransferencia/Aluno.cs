using System;
using System.Collections.Generic;

namespace ObjetoTransferencia
{
    public class Aluno : AlunoObjetivos
    {
        public Pessoa Pessoa { get; set; }
        public DateTime DataEntrada { get; set; }
    }

    public class ListaAluno : List<Aluno>
    {

    }
}
