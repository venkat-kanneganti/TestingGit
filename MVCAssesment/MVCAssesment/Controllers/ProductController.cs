using MVCAssesment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCAssesment.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        ProductStoreContext psct = new ProductStoreContext();


        [HttpPost]

        public IHttpActionResult Insert([FromBody] Product prod)
        {
            psct.product.Add(prod);
            psct.SaveChanges();
            return Ok(prod);
        }

        [Route("getall")]
        [HttpGet]

        public IHttpActionResult GetAll()
        {
           var prod = psct.product.ToList();
            return Ok(prod);
        }

        [Route("getforid")]
        [HttpGet]
        public IHttpActionResult GetForId(int id)
        {
            var cat1 = psct.product.Where(x => x.Pid == id).FirstOrDefault();
            if (cat1 == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(cat1);
            }
        }

        [Route("update")]
        [HttpPut]
        public IHttpActionResult Update(int id, [FromBody] Product prod)
        {
            if (prod.Pid == id)
            {
                psct.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                psct.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok(prod);
        }

        [Route("Delete")]
        [HttpDelete]
        public IHttpActionResult Delete(int id, [FromBody] Product prod)
        {
            if (prod.Pid == id)
            {

                psct.Entry(prod).State = System.Data.Entity.EntityState.Deleted;
                psct.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok(prod);
        }
    }
}
