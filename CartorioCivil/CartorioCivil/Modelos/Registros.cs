using CartorioCivil.Models;

namespace CartorioCivil.Modelos
{
    public class Registros
    {

        public int Id { get; set; }
        public Nascimento nascimento { get; set; }
        public int nascimentoId { get; set; }
        public Casamento casamento { get; set; }
        public int casamentoId { get; set; }

        public Obito obito { get; set; }
        public int obitoId { get; set; }

        public Registros() { }

    }
}
