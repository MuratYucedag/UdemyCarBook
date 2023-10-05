using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Core.Domain.Entities
{
    public class FooterAddress
    {
        public int FooterAddressID { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
    }
}
