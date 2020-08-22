using System;
using System.Collections.Generic;

namespace GestionClientsCore.Models
{
    public partial class RendezVous
    {
        public RendezVous()
        {
            Client = new HashSet<Client>();
        }

        public int Id { get; set; }
        public DateTime? DateRdv { get; set; }
        public string Details { get; set; }

        public virtual ICollection<Client> Client { get; set; }
    }
}
