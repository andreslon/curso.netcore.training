using MvOrders.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvOrders.Infrastructure.Interfaces
{
    public interface IProductoRepository
    {
        IList<ProductoEntity> Get();
        ProductoEntity Get(Guid Id);
        ProductoEntity Create(ProductoEntity entity);
        void Update(Guid Id, ProductoEntity entity);
        void Delete(int Id);
    }
}
