using System;

namespace PostoDeAssistenciaWeb.Models
{
    public class Assistido
    {
        public Guid AssistidoId { get; set; }

        //public Guid EnderecoId { get; set; }

        public string NomeCompleto { get; set; }

        public string Sexo { get; set; }

        public int Idade { get; set; }

        public DateTime DataNascimento { get; set; }

        public string GrauParentesco { get; set; }

        public int? Telefone1 { get; set; }

        public int? Telefone2 { get; set; }

        public int? NumeracaoCalcado { get; set; }

        public string NumeracaoRoupaSuperior { get; set; }

        public string NumeracaoRoupaInferior { get; set; }

        public string Observacao { get; set; }

        public bool Principal { get; set; }

        public Guid DependenteId { get; set; }

        public virtual Endereco Endereco { get; set; }
    }
}