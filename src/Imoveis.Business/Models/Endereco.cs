using System;
using System.Collections.Generic;
using System.Text;

namespace Imoveis.Business.Models
{
    public class Endereco
    {
        public Guid EnderecoId { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public int EnderecoImovel { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Endereco()
        {

        }
    }
}
