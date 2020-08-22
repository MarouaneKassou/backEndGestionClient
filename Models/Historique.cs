using System;
using System.Collections.Generic;

namespace GestionClientsCore.Models
{
    public partial class Historique
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string Action { get; set; }
        public int IdCompte { get; set; }

        public virtual Compte IdCompteNavigation { get; set; }
    }
}
