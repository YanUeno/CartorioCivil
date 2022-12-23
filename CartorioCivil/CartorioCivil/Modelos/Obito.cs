using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CartorioCivil.Models
{
    public class Obito
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime DataObito { get; set; }
        
        public String NomeFalecido { get; set; }
        public DateTime DataNascimento { get; set; }
        public String NomePai { get; set; }
        public String NomeMae { get; set; }
        public DateTime DataNascimentoPai { get; set; }
        public DateTime DataNascimentoMae { get; set; }

        public Obito() { } 
        public Obito(DateTime dataRegistro, DateTime dataObito, string nomeFalecido, 
            DateTime dataNascimento, string nomePai, string nomeMae, 
            DateTime dataNascimentoPai, DateTime dataNascimentoMae)
        {
            this.DataRegistro = dataRegistro;
            this.DataObito = dataObito;
            this.NomeFalecido = nomeFalecido;
            this.DataNascimento = dataNascimento;
            this.NomePai = nomePai;
            this.NomeMae = nomeMae;
            this.DataNascimentoPai = dataNascimentoPai;
            this.DataNascimentoMae = dataNascimentoMae;
        }
    }
}
