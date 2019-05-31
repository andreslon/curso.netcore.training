using MvOrders.Api.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvOrders.Api.Interfaces
{
    public interface IPedidoService
    {
        List<PedidoDto> Get();
        PedidoDto Get(Guid Id);
        PedidoDto Create(PedidoDto entity);
        void Update(Guid Id, PedidoDto entity);
        void Delete(Guid Id);
    }
}
