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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TablaProducto>().HasData(new TablaProducto
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Producto 1",
                    Precio = 100
                }
            );

            modelBuilder.Entity<TablaProducto>().HasData(new TablaProducto
                {
                    Id = Guid.NewGuid(),
                    Nombre = "Producto 2",
                    Precio = 100
                }
            );
        }
    }
}
