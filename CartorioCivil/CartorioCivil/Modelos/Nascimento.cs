using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CartorioCivil.Models
{
    public class Nascimento
    {
        [Key]
        public int id { get; set; }
        public DateTime dataRegistro { get; set; }
        public DateTime dataNascimento { get; set; }
        public String nomeRegistrado { get; set; }

        public String nomePai { get; set; }
        public DateTime nascimentoPai { get; set; }
        public String nomeMae { get; set; }
        public DateTime nascimentoMae { get; set; }

        public String cpfPai { get; set; }
        public String cpfMae { get; set; }




        public Nascimento() { }
        public Nascimento(DateTime dataRegistro, DateTime dataNascimento, String nomeRegistrado,
            String nomePai, DateTime nascimentoPai, String nomeMae, DateTime nascimentoMae,
            String cpfPai, String cpfMae)
        {
            this.dataRegistro = dataRegistro;
            this.dataNascimento = dataNascimento;
            this.nomeRegistrado = nomeRegistrado;
            this.nomePai = nomePai;
            this.nascimentoPai = nascimentoPai;
            this.nomeMae = nomeMae;
            this.nascimentoMae = nascimentoMae;
            this.cpfPai = cpfPai;
            this.cpfMae = cpfMae;
        }
    }
}
