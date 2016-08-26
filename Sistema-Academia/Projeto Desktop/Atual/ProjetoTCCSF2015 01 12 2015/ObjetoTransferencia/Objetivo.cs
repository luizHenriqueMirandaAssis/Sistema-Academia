using System;
using System.Collections.Generic;

namespace ObjetoTransferencia
{
   public  class Objetivo
    {
       public int IDObjetivo { get; set; }
       public string Descricao { get; set; }
       public DateTime DataCadastro { get; set; }
       
    }

    public class ListaObjetivo : List<Objetivo>
     {
     }   
}
