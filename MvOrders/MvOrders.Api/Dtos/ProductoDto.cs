using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvOrders.Api.Dtos
{
    public class ProductoDto
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public double Precio { get; set; }

    }
}
