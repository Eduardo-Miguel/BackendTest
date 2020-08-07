using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchBook.Models
{

    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public Specifications specifications { get; set; }

    }
}
