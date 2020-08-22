using System;
using System.Collections.Generic;

namespace GestionClientsCore.Models
{
    public partial class Document
    {
        public Document()
        {
            Client = new HashSet<Client>();
        }

        public int Id { get; set; }
        public string TypeDoc { get; set; }

        public virtual ICollection<Client> Client { get; set; }
    }
}
