using System;
using System.Collections.Generic;

namespace ObjetoTransferencia
{
    public class TipoTreinamento
    {
        public int IDTipoTreinamento { get; set; }
        public String Descricao { get; set; }
        public bool Ativo { get; set; }
    }


    public class ListaTipoTreinamento : List<TipoTreinamento>
    {
    }
}

