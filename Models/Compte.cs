using System;
using System.Collections.Generic;

namespace GestionClientsCore.Models
{
    public partial class Compte
    {
        public Compte()
        {
            Historique = new HashSet<Historique>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int IdUtilisateur { get; set; }

        public virtual Utilisateur IdUtilisateurNavigation { get; set; }
        public virtual ICollection<Historique> Historique { get; set; }
    }
}
