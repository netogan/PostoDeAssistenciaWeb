using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostoDeAssistenciaWeb.Models
{
    public class Endereco
    {
        public Guid EnderecoId { get; set; }

        public string Uf { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }

        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        public virtual Assistido Assistido { get; set; }
    }
}