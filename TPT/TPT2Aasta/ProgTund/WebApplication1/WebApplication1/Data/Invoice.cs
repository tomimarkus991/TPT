using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class Invoice
    {
        public int Id{ get; set; }
        public DateTime Date { get; set; }
        public string InvoiceNo { get; set; }
        public IList<InvoiceLine> Lines { get; set; }
        public Invoice()
        {
            Lines = new List<InvoiceLine>();
        }
    }
}
