using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ProbaZaMongoDB
{
    class Account
    {
        

        public ObjectId id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        
    }

}
