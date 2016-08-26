using System.Collections.Generic;

namespace ObjetoTransferencia
{
    public class ExerciciosTreinamento
    {
        public Treinamento Treinamento { get; set; }
        public Exercicio Exercicio { get; set; }
        public int Series { get; set; }
        public int Repeticoes { get; set; }

        public string Intervalo { get; set; }
    }

    public class ListaExerciciosTreinamento : List<ExerciciosTreinamento>
    {

    }
}
