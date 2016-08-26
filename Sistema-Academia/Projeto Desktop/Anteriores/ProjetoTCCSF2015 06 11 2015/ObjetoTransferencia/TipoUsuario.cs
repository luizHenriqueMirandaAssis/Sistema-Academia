using System.Collections.Generic;

namespace ObjetoTransferencia
{
   public  class TipoUsuario
    {
        public int IDTipoUsuario { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }

   public class ListaTipoUsuario : List<TipoUsuario>
   {
   }
}
