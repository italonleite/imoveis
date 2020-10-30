using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Imoveis.Business.Models
{
    public class User : Entity
    {
        public Guid UserId { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Announcement> announcements{ get; set; }

        public User()
        {

        }

        public User(Guid userId, string login, string email, string password)
        {
            UserId = userId;
            Login = login;
            Email = email;
            Password = password;           
        }

        public Announcement CreateAnnouncement(Guid announcementId, decimal usefulArea, int bedroom, int bathroom, int suite, int vacancy, int walk, string description, decimal value, User user, Immobile immobile)
        {

            var announcement = new Announcement()
            {
                AnnouncementId = announcementId,
                UsefulArea = usefulArea,
                Bedroom = bedroom,
                Bathroom = bathroom,
                Suite = suite,
                Vacancy = vacancy,
                Walk = walk,
                Description = description,
                Value = value,                
                User = user,
                Immobile = immobile
            };


            return announcement;
        }

        public override bool IsValid()
        {
           ValidationResult = new UsuarioValidacao().Validate(this);
            return ValidationResult.IsValid;
        }
    }

    public class UsuarioValidacao : AbstractValidator<User>
    {
        public UsuarioValidacao()
        {
            RuleFor(u => u.Login)
                .NotEmpty().WithMessage("Por favor, certifique-se de ter inserido o nome")
                .Length(2, 20).WithMessage("O Login deve ter entre 2 e 20 caracteres");

            RuleFor(u => u.Password)
               .NotEmpty().WithMessage("Por favor, certifique-se de ter inserido a senha");
              

            RuleFor(u => u.Email)
                .NotEmpty().EmailAddress();

            RuleFor(u => u.UserId)
                .NotEqual(Guid.Empty);
        }
    }
    }

