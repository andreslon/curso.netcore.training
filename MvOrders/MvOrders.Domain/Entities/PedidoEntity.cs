using System;
using System.Collections.Generic;
using System.Text;

namespace MvOrders.Domain.Entities
{
    public class PedidoEntity
    {
        public Guid Id { get; set; }
        public String Usuario { get; set; }
        public DateTime FechaPedido { get; set; }
        public double Total { get; set; }
    }
}
