using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ProbaZaMongoDB
{
    class Reference
    {
        public ObjectId Id { get; set; }
        public string Username { get; set; }
        
        public string FileID { get; set; }

    }
}
