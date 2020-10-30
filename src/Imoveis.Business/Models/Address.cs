using System;
using System.Collections.Generic;
using System.Text;

namespace Imoveis.Business.Models
{
    public class Address
    {
        public Guid EnderecoId { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string EnderecoImovel { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Address()
        {

        }

        public Address(Guid enderecoId, string cep, string bairro, string enderecoImovel, string cidade, string estado)
        {
            EnderecoId = enderecoId;
            Cep = cep;
            Bairro = bairro;
            EnderecoImovel = enderecoImovel;
            Cidade = cidade;
            Estado = estado;
        }
    }
}
