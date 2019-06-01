using MvOrders.Api.Dtos;
using MvOrders.Api.Interfaces;
using MvOrders.Domain.Entities;
using MvOrders.Infrastructure.Interfaces;
using MvOrders.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvOrders.Api.services
{
    public class ProductoService : IProductoService
    {
        public IProductoRepository ProductoRepository { get; set; }
        public ProductoService(IProductoRepository productoRepository)
        {
            ProductoRepository = productoRepository;
        }

        public IList<ProductoDto> Get()
        {
            var list = ProductoRepository.Get();
            return list.Select(product => new ProductoDto
            {
                Id = product.Id,
                Nombre = product.Nombre,
                Precio = product.Precio

            }).ToList();
        }

     
    }
}
