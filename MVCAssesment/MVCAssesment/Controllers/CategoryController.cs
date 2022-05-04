using MVCAssesment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



namespace MVCAssesment.Controllers
{
    [RoutePrefix("api/Category")]
    public class CategoryController : ApiController
    {
        ProductStoreContext psc = new ProductStoreContext();

        [HttpPost]

        public IHttpActionResult Insert([FromBody] Category cat)
        {
            psc.category.Add(cat);
            psc.SaveChanges();
            return Ok(cat);
        }

        [Route("GetAll")]
        [HttpGet]

        public IHttpActionResult GetAll()
        {
            var cat = psc.category.ToList();
            return Ok(cat);
        }

        [Route("getforid")]
        [HttpGet]
        public IHttpActionResult GetForId(int id)
        {
            var cat1 = psc.category.Where(x => x.CategoryId == id).FirstOrDefault();
            if (cat1 == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(cat1);
            }

            //api / category / update / id /{ id}/ category /{ category}

        }
        [Route("update")]
        [HttpPut]
        public IHttpActionResult Update(int id, [FromBody] Category cat)
        {
            if (cat.CategoryId == id)
            {
                psc.Entry(cat).State = System.Data.Entity.EntityState.Modified;
                psc.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok(cat);
        }
        [Route("Delete")]
        [HttpDelete]
        public IHttpActionResult Delete(int id, [FromBody] Category cat)
        {
            if (cat.CategoryId == id)
            {
                
                psc.Entry(cat).State = System.Data.Entity.EntityState.Deleted;
                psc.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok(cat);
        }

    }
}
