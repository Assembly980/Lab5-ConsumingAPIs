using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Lab
{
    internal class CatResult
    {
        public string _id { get; set; }
        public string user { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public bool? deleted { get; set; }
        public string createdAt { get; set; }
        public string? updatedAt { get; set; }
        public int __v { get; set; }


        public CatResult() { }

        public CatResult(string iD, int v, string text, string lastUpdate, bool deleted, string createdAt, string user, string type)
        {
            _id = iD;
            __v = v;
            this.user = user;
            this.text = text;
            this.type = type;
            this.createdAt = createdAt;
            this.updatedAt = lastUpdate;
            this.deleted = deleted;
        }

        public override string ToString()
        {
            string msg = $"Fact: {text}\n";
            return msg;
        }
    }
}
