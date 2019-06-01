using System;
using System.Collections.Generic;
using System.Text;
using MvOrders.Domain.Entities;

namespace MvOrders.Infrastructure.Interfaces
{
    public interface IPedidoRepository
    {
        IList<PedidoEntity> Get();
        PedidoEntity Get(Guid Id);
        PedidoEntity Create(PedidoEntity entity);
        //void Update(Guid Id, PedidoEntity entity);
        //void Delete(int Id);
    }
}
