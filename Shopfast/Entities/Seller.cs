using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopfast.Entities
{
    public class Seller
    {
        int id;
        string name;
        string lastname;
        string email;
        string phone;
        string address;
        int personId;

        public Seller(int id, string name, string lastname, string email, string phone, string address, int personId)
        {
            this.id = id;
            this.name = name;
            this.lastname = lastname;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.personId = personId;
        }

        public Seller(string name, string lastname, string email, string phone, string address, int personId)
        {
            this.name = name;
            this.lastname = lastname;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.personId = personId;
        }
    }

}