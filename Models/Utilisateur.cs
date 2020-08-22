using System;
using System.Collections.Generic;

namespace GestionClientsCore.Models
{
    public partial class Utilisateur
    {
        public Utilisateur()
        {
            Client = new HashSet<Client>();
            Compte = new HashSet<Compte>();
            Groupe = new HashSet<Groupe>();
        }

        public int Id { get; set; }
        public string Cin { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public int? IdRole { get; set; }

        public virtual Role IdRoleNavigation { get; set; }
        public virtual ICollection<Client> Client { get; set; }
        public virtual ICollection<Compte> Compte { get; set; }
        public virtual ICollection<Groupe> Groupe { get; set; }
    }
}
