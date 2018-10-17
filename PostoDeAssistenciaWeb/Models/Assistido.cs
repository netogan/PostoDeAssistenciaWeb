using System;
using System.ComponentModel.DataAnnotations;

namespace PostoDeAssistenciaWeb.Models
{
    public class Assistido
    {
        public Guid AssistidoId { get; set; }

        //public Guid EnderecoId { get; set; }

        [Required(ErrorMessage = "Informe o nome completo", AllowEmptyStrings = false)]
        public string NomeCompleto { get; set; }

        public string Sexo { get; set; }

        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Informe uma idade válida")]
        public int Idade { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DataNascimento { get; set; }

        public string GrauParentesco { get; set; }

        public int? Telefone1 { get; set; }

        public int? Telefone2 { get; set; }

        public int? NumeracaoCalcado { get; set; }

        public string NumeracaoRoupaSuperior { get; set; }

        public string NumeracaoRoupaInferior { get; set; }

        public string Observacao { get; set; }

        public bool Principal { get; set; }

        public Guid? DependenteId { get; set; }

        public virtual Endereco Endereco { get; set; }
    }
}