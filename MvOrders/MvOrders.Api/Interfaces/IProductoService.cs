﻿using MvOrders.Api.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvOrders.Api.Interfaces
{
    public interface IProductoService
    {
        List<ProductoDto> Get();
        //ProductoDto Get(Guid Id);
        //ProductoDto Create(ProductoDto entity);
        //void Update(Guid Id, ProductoDto entity);
        //void Delete(Guid Id);
    }
}
