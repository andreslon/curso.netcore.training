using System;
using System.Collections.Generic;
using System.Text;

namespace MvOrders.Infrastructure.Tables
{
    public class TablaDetallePedido
    {
        public Guid Id { get; set; }
        public Guid PedidoId { get; set; }
        public Guid ProductoId { get; set; }
        public int Cantidad { get; set; }

        public TablaPedido Pedido { get; set; }
        public TablaProducto Producto { get; set; }
    }
}
