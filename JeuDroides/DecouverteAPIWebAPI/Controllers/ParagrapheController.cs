using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MaSuperLibrarie.Data_Layers;
using MaSuperLibrarie.Models;

namespace DecouverteAPIWebAPI.Controllers
{
    public class ParagrapheController : ApiController
    {
        private ParagrapheDataLayer dl = new ParagrapheDataLayer();

        // GET api/values
        public IEnumerable<Paragraphe> Get()
        {
            return dl.GetAll();
        }

        // GET api/values/5
        public Paragraphe Get(int id)
        {
            return dl.GetOne(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
