using FluentValidation.Results;
using System;

namespace Imoveis.Business.Models
{
    public abstract class Entity
    {
       
        public ValidationResult ValidationResult { get; protected set; }

        public virtual bool EhValido()
        {
            throw new NotImplementedException();
        }        
    }
}