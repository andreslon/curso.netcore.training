using System;
using System.Collections.Generic;
using System.Text;

namespace MvOrders.Domain.Entities
{
    public class ProductoEntity
    {
        public Guid Id { get; set; }
        public String Nombre { get; set; }
        public double Precio { get; set; }
    }
}
