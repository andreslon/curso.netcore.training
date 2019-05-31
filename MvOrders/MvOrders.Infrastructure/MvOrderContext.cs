using Microsoft.EntityFrameworkCore;
using MvOrders.Infrastructure.Tables;
using System;

namespace MvOrders.Infrastructure
{
    public class MvOrderContext:DbContext
    {
        //Mapeo de tabla
        public DbSet<TablaProducto> Producto { get; set; }
        public DbSet<TablaPedido> Pedido { get; set; }
        public DbSet<TablaDetallePedido> DetallePedido { get; set; }

        public MvOrderContext(DbContextOptions<MvOrderContext> options) :
            base(options)
        {

        }
    }
}
