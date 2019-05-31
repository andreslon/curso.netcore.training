using MvOrders.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvOrders.Infrastructure.Interfaces
{
    interface IDetallePedidoRepository
    {
        IList<DetallePedidoEntity> Get();
        DetallePedidoEntity Get(Guid Id);
        DetallePedidoEntity Create(DetallePedidoEntity entity);
        void Update(Guid Id, DetallePedidoEntity entity);
        void Delete(int Id);
    }
}
