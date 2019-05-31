using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvOrders.Api.Dtos
{
    public class PedidoDto
    {
        public Guid Id { get; set; }
        public String Usuario { get; set; }
        public DateTime FechaPedido { get; set; }
        public double Total { get; set; }
                                                   
    }
}
