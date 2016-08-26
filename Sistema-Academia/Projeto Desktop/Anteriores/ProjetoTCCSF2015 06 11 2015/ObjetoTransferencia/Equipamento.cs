using System.Collections.Generic;

namespace ObjetoTransferencia
{
    public class Equipamento
    {
        public int IDEquipamento { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public bool Ativo { get; set; }

    }

    public class ListaEquipamento : List<Equipamento>
    {

    }
}
