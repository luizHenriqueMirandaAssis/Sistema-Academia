using System.Collections.Generic;

namespace ObjetoTransferencia
{
    public class AlunoObjetivos
    {
        public Objetivo Objetivo { get; set; }
        public Aluno Aluno { get; set; }
        public string Status { get; set; }
    }

    public class ListaAlunoObjetivos : List<AlunoObjetivos>
    {

    }
}
