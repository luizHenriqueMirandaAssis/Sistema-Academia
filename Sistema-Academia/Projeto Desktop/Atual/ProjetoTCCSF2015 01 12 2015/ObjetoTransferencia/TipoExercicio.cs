using System.Collections.Generic;

namespace ObjetoTransferencia
{
    public class TipoExercicio
    {
        public int IDTipoExercicio { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }

    public class ListaTipoExercicio : List<TipoExercicio>
    {

    }
}
