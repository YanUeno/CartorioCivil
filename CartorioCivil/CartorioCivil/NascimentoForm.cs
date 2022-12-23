using CartorioCivil.Models;

namespace CartorioCivil
{
    public class NascimentoForm
    {
        public DateTime dataRegistro { get; set; }
        public DateTime nascimento { get; set;}
        public String nomeRegistro { get; set; }
        public String nomePai { get; set; }
        public DateTime nascimentoPai { get; set; }
        public String nomeMae { get; set; }
        public DateTime nascimentoMae { get; set; }
        public String cpfPai { get; set; }
        public String cpfMae { get; set; }
        public NascimentoForm() { }
        public NascimentoForm(DateTime dataRegistro, DateTime nascimento, string nomeRegistro, string nomePai, DateTime nascimentoPai, string nomeMae, DateTime nascimentoMae, string cpfPai, string cpfMae)
        {
            this.dataRegistro = dataRegistro;
            this.nascimento = nascimento;
            this.nomeRegistro = nomeRegistro;
            this.nomePai = nomePai;
            this.nascimentoPai = nascimentoPai;
            this.nomeMae = nomeMae;
            this.nascimentoMae = nascimentoMae;
            this.cpfPai = cpfPai;
            this.cpfMae = cpfMae;
        }

        public Nascimento Converter()
        {
            return new Nascimento(dataRegistro, nascimento, nomeRegistro, nomePai, nascimentoPai, nomeMae, nascimentoMae, cpfPai, cpfMae);
        }
    }
}
