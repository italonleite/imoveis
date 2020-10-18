using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Imoveis.Business.Models
{
    public class Usuario : Entity
    {
        public Guid UsuarioId { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }  
   
        public Usuario()
        {

        }

        public Usuario(Guid usuarioId, string login, string email, string senha)
        {
            UsuarioId = usuarioId;
            Login = login;
            Email = email;
            Senha = senha;
        }

        public Anuncio CriarAnuncio(Guid anuncioId, decimal areaUtil, int quarto, int banheiro, int suite, int vaga, int andar, decimal valor, Endereco endereco, Guid usuarioId, TipoImovel tipoImovel)
        {

            var Anuncio = new Anuncio()
            {
                AnuncioId = anuncioId,
                AreaUtil = areaUtil,
                Quarto = quarto,
                Banheiro = banheiro,
                Suite = suite,
                Vaga = vaga,
                Andar = andar,
                Valor = valor,
                Endereco = endereco,
                UsuarioId = usuarioId,
                TipoImovel = tipoImovel
            };


            return Anuncio;
        }

        public override bool EhValido()
        {
           ValidationResult = new UsuarioValidacao().Validate(this);
            return ValidationResult.IsValid;
        }
    }

    public class UsuarioValidacao : AbstractValidator<Usuario>
    {
        public UsuarioValidacao()
        {
            RuleFor(u => u.Login)
                .NotEmpty().WithMessage("Por favor, certifique-se de ter inserido o nome")
                .Length(2, 20).WithMessage("O Login deve ter entre 2 e 20 caracteres");

            RuleFor(u => u.Senha)
               .NotEmpty().WithMessage("Por favor, certifique-se de ter inserido a senha");
              

            RuleFor(u => u.Email)
                .NotEmpty().EmailAddress();

            RuleFor(u => u.UsuarioId)
                .NotEqual(Guid.Empty);
        }
    }
    }

