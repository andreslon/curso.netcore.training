using MvOrders.Api.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvOrders.Api.Interfaces
{
    interface IDetallePedido
    {
        List<DetallePedidoDto> Get();
        DetallePedidoDto Get(Guid Id);
        DetallePedidoDto Create(DetallePedidoDto entity);
        void Update(Guid Id, DetallePedidoDto entity);
        void Delete(Guid Id);
    }
}
