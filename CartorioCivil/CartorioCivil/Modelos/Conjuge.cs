using CartorioCivil.Models;

namespace CartorioCivil.Modelos
{
    public class Conjuge
    {
        public int Id { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public String NomePai { get; set; }
        public String NomeMae { get; set; }
        public DateTime DataNascimentoPai { get; set; }
        public DateTime DataNascimentoMae { get; set; }
        public String CpfPai { get; set; }
        public String CpfMae { get; set; }

        public Casamento casamento { get; set; }

        public Conjuge() { }
        public Conjuge( DateTime dataNascimento, string name, string cpf, string nomePai, string nomeMae, DateTime dataNascimentoPai, DateTime dataNascimentoMae, string cpfPai, string cpfMae)
        {
            this.DataNascimento = dataNascimento;
            this.Name = name;
            this.Cpf = cpf;
            this.NomePai = nomePai;
            this.NomeMae = nomeMae;
            this.DataNascimentoPai = dataNascimentoPai;
            this.DataNascimentoMae = dataNascimentoMae;
            this.CpfPai = cpfPai;
            this.CpfMae = cpfMae;
        }
    }
}
