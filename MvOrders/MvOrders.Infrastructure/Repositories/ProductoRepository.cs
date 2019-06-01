using MvOrders.Domain.Entities;
using MvOrders.Infrastructure.Interfaces;
using MvOrders.Infrastructure.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvOrders.Infrastructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        public MvOrderContext Context { get; set; }

        public ProductoRepository(MvOrderContext context)
        {
            Context = context;
        }
        public IList<ProductoEntity> Get()
        {

            IList<ProductoEntity> productos = Context.Producto.Select(p => new ProductoEntity
            {
                Id= p.Id,
                Nombre = p.Nombre,
                Precio = p.Precio
            }).ToList(); 

            return productos;
        }
    }
}
