using System;
using System.Collections.Generic;
using System.Text;

namespace MvOrders.Infrastructure.Tables
{
    public class TablaProducto
    {
        public Guid Id { get; set; }
        public String Nombre { get; set; }
        public double Precio { get; set; }
    }
}
