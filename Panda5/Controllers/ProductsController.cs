using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Panda5.Controllers
{
    public class ProductsController : ApiController
    {
        [Route("api/products")]
        public JArray GetAllProducts()
        {
            return JArray.FromObject(new NorthwindEntities().products.ToList());
        }

        [Route("api/product/{id}")]
        public JObject GetProduct(int id)
        {
            product product = new NorthwindEntities().products.FirstOrDefault(x => x.productid == id);
            return JObject.FromObject(product);

            /*
            if (product == null)
                return NotFound();

            return Ok(product);
            */
        }

    }
}
