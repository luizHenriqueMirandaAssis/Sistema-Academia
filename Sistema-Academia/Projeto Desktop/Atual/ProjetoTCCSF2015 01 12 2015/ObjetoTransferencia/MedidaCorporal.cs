using System;
using System.Collections.Generic;

namespace ObjetoTransferencia
{
    public class MedidaCorporal
    {
        public int IDMedidaCorporal { get; set; }
        public Aluno Aluno { get; set; }
        public TipoMedidaCorporal TipoMedidaCorporal { get; set; }
        public DateTime DataMedida { get; set; }
        public decimal MedidaCm { get; set; }
        public bool Ativo { get; set; }
    }

    public class ListaMedidaCorporal : List<MedidaCorporal>
    {

    }
}
