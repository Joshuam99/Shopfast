using Shopfast.Entities;
using Shopfast.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace WebApi.Controllers
{
    public class CustomerController: ApiController
    {

        [HttpPost]
        [Route("api/Customer")]
        public Response SaveCustomer(ReqCustomer req)
        {
            CustomerLogic customerLogic = new CustomerLogic();
            return customerLogic.SaveCustomer(req);

        }


    }
}