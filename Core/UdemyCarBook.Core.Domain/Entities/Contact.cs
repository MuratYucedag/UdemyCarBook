using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Core.Domain.Entities
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string NameSurname { get; set; }
        public string Subject { get; set; }
        public string Mail { get; set; }
        public string MessageContent { get; set; }
        public DateTime SendDate { get; set; }
    }
}
