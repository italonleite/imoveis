using System;
using System.Collections.Generic;
using System.Text;

namespace Imoveis.Business.Models
{
    public class Imovel
    {
        public Guid ImovelId { get; set; }
        public string Nome { get; set; }
        public ECaracteristica ECaracteristica { get; set; }
        public Guid EnderecoId { get; set; }
        public Endereco Endereco { get; set; }

        public Imovel()
        {

        }

        public Imovel(Guid imovelId, string nome, ECaracteristica eCaracteristica, Guid enderecoId, Endereco endereco)
        {
            ImovelId = imovelId;
            Nome = nome;
            ECaracteristica = eCaracteristica;
            EnderecoId = enderecoId;
            Endereco = endereco;
        }
    }

}
