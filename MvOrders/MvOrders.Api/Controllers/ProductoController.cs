using Microsoft.AspNetCore.Mvc;
using MvOrders.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvOrders.Api.Controllers
{
    [Route("api/v1/[controller]")]
    public class ProductoController : Controller
    {
        public IProductoService ProductoService { get; set; }
        public ProductoController(IProductoService productoService)
        {
            ProductoService = productoService;
        }

        //GET api/v1/productos
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(ProductoService.Get());

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
