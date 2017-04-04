using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSA_kindle
{
    public abstract class Article
    {
        public Subject Subject { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DateTime Time { get; set; }
        public bool HasRead { get; set; }

    }
}
