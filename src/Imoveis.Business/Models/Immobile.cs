using System;
using System.Collections.Generic;
using System.Text;

namespace Imoveis.Business.Models
{
    public class Immobile
    {
        public Guid ImmobileId { get; set; }       
        public EType EType { get; set; }
        public Address Address { get; set; }

        public Immobile()
        {

        }

        public Immobile(Guid immobileId, EType eType, Address address)
        {
            ImmobileId = immobileId;           
            EType = eType;
            Address = address;
        }
    }

}
