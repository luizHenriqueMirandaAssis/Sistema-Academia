using System;
using System.Collections.Generic;

namespace ObjetoTransferencia
{
    public class Usuario
    {
        public Pessoa Pessoa { get; set; }
        public DateTime DataCadastro { get; set; }
       public TipoUsuario TipoUsuario { get; set; }   
    }

    public class ListaUsuario: List<Usuario>
    {
    }
}
