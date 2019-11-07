using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class InvoiceLine
    {
        public int Id { get; set; }
        public string LineItem{ get; set; }
        public double Sum { get; set; }
    }
}
