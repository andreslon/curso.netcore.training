using System;
using System.Collections.Generic;
using System.Text;

namespace MvOrders.Domain.Entities
{
    public class DetallePedidoEntity
    {
        public Guid Id { get; set; }
        public Guid PedidoId { get; set; }
        public Guid ProductoId { get; set; }
    }
}
