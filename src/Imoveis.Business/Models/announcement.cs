using System;
using System.Collections.Generic;
using System.Text;

namespace Imoveis.Business.Models
{
    //anuncio
    public class Announcement
    {   
        public Guid AnnouncementId { get; set; }
        //area util
        public decimal UsefulArea { get; set; }
        //quarto
        public int Bedroom { get; set; }
        //banheiro
        public int Bathroom { get; set; }
        public int Suite { get; set; }
        //vaga
        public int Vacancy { get; set; }
        //andar
        public int Walk { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public decimal CondominiumValue { get; set; }
        public decimal Iptu { get; set; }
        public User User { get; set; }      
        public Immobile Immobile { get; set; }

        public Announcement()
        {

        }

        public Announcement(Guid announcementId, decimal usefulArea, int bedroom, int bathroom, int suite, int vacancy, int walk, string description, decimal value, decimal condominiumValue, decimal iptu, User user, Immobile immobile)
        {
            AnnouncementId = announcementId;
            UsefulArea = usefulArea;
            Bedroom = bedroom;
            Bathroom = bathroom;
            Suite = suite;
            Vacancy = vacancy;
            Walk = walk;
            Description = description;
            Value = value;
            CondominiumValue = condominiumValue;
            Iptu = iptu;
            User = user;
            Immobile = immobile;
        }
    }
}
