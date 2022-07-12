using EcomDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EcomDAL
{
    public class ProductRepository
    {
        ProductDBContext _context;

        public ProductRepository()
        {
            _context = new ProductDBContext();
        }

        //Fetch Products from Database
        public List<Product> FetchProducts()
        {
            List<Product> lst=new List<Product>();
            try
            {
                lst= ( from p in _context.Product
                       select p ).ToList();
            }
            catch (Exception)
            {

                
            }

            return lst;

        }


    }
}
