using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ProductsWepAPI.Models;

namespace ProductsWepAPI.Controllers
{
    public class tbl_products_master_transController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/tbl_products_master_trans
        public IQueryable<tbl_products_master_trans> Gettbl_products_master_trans()
        {
            return db.tbl_products_master_trans;
        }

        // GET: api/tbl_products_master_trans/5
        [ResponseType(typeof(tbl_products_master_trans))]
        public IHttpActionResult Gettbl_products_master_trans(int id)
        {
            tbl_products_master_trans tbl_products_master_trans = db.tbl_products_master_trans.Find(id);
            if (tbl_products_master_trans == null)
            {
                return NotFound();
            }

            return Ok(tbl_products_master_trans);
        }

        // PUT: api/tbl_products_master_trans/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttbl_products_master_trans(int id, tbl_products_master_trans tbl_products_master_trans)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_products_master_trans.id)
            {
                return BadRequest();
            }

            db.Entry(tbl_products_master_trans).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbl_products_master_transExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/tbl_products_master_trans
        [ResponseType(typeof(tbl_products_master_trans))]
        public IHttpActionResult Posttbl_products_master_trans(tbl_products_master_trans tbl_products_master_trans)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tbl_products_master_trans.Add(tbl_products_master_trans);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tbl_products_master_trans.id }, tbl_products_master_trans);
        }

        // DELETE: api/tbl_products_master_trans/5
        [ResponseType(typeof(tbl_products_master_trans))]
        public IHttpActionResult Deletetbl_products_master_trans(int id)
        {
            tbl_products_master_trans tbl_products_master_trans = db.tbl_products_master_trans.Find(id);
            if (tbl_products_master_trans == null)
            {
                return NotFound();
            }

            db.tbl_products_master_trans.Remove(tbl_products_master_trans);
            db.SaveChanges();

            return Ok(tbl_products_master_trans);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tbl_products_master_transExists(int id)
        {
            return db.tbl_products_master_trans.Count(e => e.id == id) > 0;
        }
    }
}