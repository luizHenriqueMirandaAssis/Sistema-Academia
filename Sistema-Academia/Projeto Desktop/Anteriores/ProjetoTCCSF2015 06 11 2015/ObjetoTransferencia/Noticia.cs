using System;
using System.Collections.Generic;

namespace ObjetoTransferencia
{
    public class Noticia
    {
        public int IDNoticia { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataNoticia { get; set; }
        public bool Ativo { get; set; }
    }

    public class ListaNoticia : List<Noticia>
    {

    }
}
