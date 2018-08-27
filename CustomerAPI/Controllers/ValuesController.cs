using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomerAPI.Models;

namespace CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        #region MyRegion
        private IEnumerable<Customer> BuildCustomerList()
        {
            List<Customer> lCustomer = new List<Customer>();

            lCustomer.Add(new Customer { FirstName = "bob", LastName = "brown", PhoneNumber = "1234567" });
            lCustomer.Add(new Customer { FirstName = "Joshua", LastName = "brown", PhoneNumber = "1234567" });
            lCustomer.Add(new Customer { FirstName = "Jim", LastName = "brown", PhoneNumber = "1234567" });

            return lCustomer.AsEnumerable();
        }
        #endregion
        // GET api/values
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return BuildCustomerList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
