using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi_尝试1.Models;
namespace webapi_尝试1.Controllers
{
    public class ProductsController : ApiController
    {
           // 创建 一个数组 ，假数据
        Product[] products = new Product[]
       {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
       };


       /// <summary>
       /// 获取产品列表  get
       /// </summary>
       /// <returns></returns>
     
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

       /// <summary>
       /// 根据id获取产品 get
       /// </summary>
       /// <returns></returns>
      
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(p=>p.Id==id);
            if(product==null)
            {
                return NotFound();
            }
            return Ok(product);

        }
    }
}
