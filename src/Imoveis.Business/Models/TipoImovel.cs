using System;
using System.Collections.Generic;
using System.Text;

namespace Imoveis.Business.Models
{
    public class TipoImovel
    {
        public Guid TipoImovelId { get; set; }
        public string Nome { get; set; }
        public ECaracteristica ECaracteristica { get; set; }

        public TipoImovel()
        {

        }

        public TipoImovel(Guid tipoImovelId, string nome, ECaracteristica eCaracteristica)
        {
            TipoImovelId = tipoImovelId;
            Nome = nome;
            ECaracteristica = eCaracteristica;
        }
    }

}
