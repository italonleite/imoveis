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
        public Endereco Endereco { get; set; }

        public Imovel()
        {

        }

        public Imovel(Guid imovelId, string nome, ECaracteristica eCaracteristica, Endereco endereco)
        {
            ImovelId = imovelId;
            Nome = nome;
            ECaracteristica = eCaracteristica;
            Endereco = endereco;
        }
    }

}
