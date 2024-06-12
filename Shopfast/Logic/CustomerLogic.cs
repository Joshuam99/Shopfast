using Shopfast.DataAccess;
using Shopfast.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Shopfast.Logic
{
    public class CustomerLogic
    {
        Response response = new Response();


   public Response SaveCustomer(ReqCustomer req) {


            if (string.IsNullOrEmpty(req.thisCustomer.name))
            {
                response.result = 0;
                response.message = "null name";
            }
            else if (string.IsNullOrEmpty(req.thisCustomer.lastname))
            {
                response.result = 0;
                response.message = "null lastname";
            }
            else if (string.IsNullOrEmpty(req.thisCustomer.phone))
            {
                response.result = 0;
                response.message = "null phone number";
            }
            else if (string.IsNullOrEmpty(req.thisCustomer.address))
            {
                response.result = 0;
                response.message = "null address";
            }
            else if (string.IsNullOrEmpty(req.thisCustomer.email))
            {
                response.result = 0;
                response.message = "null email";
            }
            else if (string.IsNullOrEmpty(req.thisCustomer.password))
            {
                response.result = 0;
                response.message = "null password";
            }
            else {


                try {
                    int? result = 0;
                    string message = "";


                    LinQDataContext linq = new LinQDataContext();

                    linq.savaCustomer(req.thisCustomer.name, req.thisCustomer.lastname, req.thisCustomer.password, req.thisCustomer.email, req.thisCustomer.phone, req.thisCustomer.address, ref result, ref message);

                    if (result == 1)
                    {
                        response.result = 1;
                        response.message = message;
                    }
                    else if (result == 2)
                    {
                        response.result = 2;
                        response.message = message;
                    }
                    else if (result == 0)
                    {
                        response.result = 0;
                        response.message = message;

                    }

                } catch (Exception e)
                { 
                    response.message += e.ToString();
                
                }

                

            }

            return response;
        }




    }
}