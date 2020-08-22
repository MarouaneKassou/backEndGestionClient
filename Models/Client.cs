using System;
using System.Collections.Generic;

namespace GestionClientsCore.Models
{
    public partial class Client
    {
        public int Id { get; set; }
        public string Cin { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public int IdUser { get; set; }
        public int IdGroupe { get; set; }
        public int IdDoc { get; set; }
        public int IdRdv { get; set; }

        public virtual Document IdDocNavigation { get; set; }
        public virtual Groupe IdGroupeNavigation { get; set; }
        public virtual RendezVous IdRdvNavigation { get; set; }
        public virtual Utilisateur IdUserNavigation { get; set; }
    }
}
