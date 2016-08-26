using System.Collections.Generic;

namespace ObjetoTransferencia
{
    public class TipoMedidaCorporal
    {
        public int IDTipoMedidaCorporal { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }

    public class ListaTipoMedidaCorporal : List<TipoMedidaCorporal>
    {

    }
}
