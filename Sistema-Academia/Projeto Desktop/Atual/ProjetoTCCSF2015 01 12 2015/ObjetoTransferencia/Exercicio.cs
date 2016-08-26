using System.Collections.Generic;

namespace ObjetoTransferencia
{
    public class Exercicio
    {
        public int IDExercicio { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string DemonstracaoUrlImagem { get; set; }
        public string DemonstracaoUrlVideo { get; set; }
        public TipoExercicio TipoExercicio { get; set; }
    }

    public class ListaExercicio : List<Exercicio>
    {

    }
}
