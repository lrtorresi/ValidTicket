using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Entities
{
    public class Ticket
    {
        public string QrCode { get; set; }
        public string ContaId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime ConsumoAt { get; set; }
        public int ItemId { get; set; }
        public string Item { get; set; }
    }
}
