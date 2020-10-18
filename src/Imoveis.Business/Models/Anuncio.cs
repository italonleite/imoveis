using System;
using System.Collections.Generic;
using System.Text;

namespace Imoveis.Business.Models
{
    public class Anuncio
    {
        public Guid AnuncioId { get; set; }
        public decimal AreaUtil { get; set; }
        public int Quarto { get; set; }
        public int Banheiro { get; set; }
        public int Suite { get; set; }
        public int Vaga { get; set; }
        public int Andar { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorCondomomio { get; set; }
        public decimal Iptu { get; set; }
        public Endereco Endereco { get; set; }
        public Guid UsuarioId { get; set; }
        public TipoImovel TipoImovel { get; set; }

        public Anuncio()
        {

        }

        
    }
}
