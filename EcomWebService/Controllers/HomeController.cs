//using EcomDAL.Model;
using EcomDAL;
using EcomDAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace EcomWebService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : Controller
    {

        ProductRepository productRepository;
        public HomeController()
        {
            productRepository = new ProductRepository();

        }

        [HttpGet]
        public List<Product> GetProducts()
        {
            List<Product> lst = new List<Product>();

            try
            {
                lst = productRepository.FetchProducts();
            }
            catch (Exception e)
            {
                lst = null;
            }
            return lst;

        }



    }
}
