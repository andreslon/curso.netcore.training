using System;
using System.Collections.Generic;
using System.Text;

namespace MvOrders.Infrastructure.Tables
{
    public class TablaPedido
    {
        public Guid Id { get; set; }
        public String Usuario { get; set; }
        public DateTime FechaPedido { get; set; }
        public double Total { get; set; }

        public List<TablaDetallePedido> DetallePedido { get; set; }
    }
}
