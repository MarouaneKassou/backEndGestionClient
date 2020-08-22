using System;
using System.Collections.Generic;

namespace GestionClientsCore.Models
{
    public partial class Groupe
    {
        public Groupe()
        {
            Client = new HashSet<Client>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public int IdUser { get; set; }

        public virtual Utilisateur IdUserNavigation { get; set; }
        public virtual ICollection<Client> Client { get; set; }
    }
}
