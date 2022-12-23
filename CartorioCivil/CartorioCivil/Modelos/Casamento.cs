using CartorioCivil.Modelos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CartorioCivil.Models
{
    public class Casamento
    {
        [Key]

        public int Id { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime DataCasamento { get; set; }
        public ICollection<Conjuge> conjuges { get; set; }


        public Casamento() { }

        public Casamento( DateTime dataRegistro, DateTime dataCasamento, List<Conjuge> conjuges)
        {
            DataRegistro = dataRegistro;
            DataCasamento = dataCasamento;
            this.conjuges = conjuges;
        }
    }
}
