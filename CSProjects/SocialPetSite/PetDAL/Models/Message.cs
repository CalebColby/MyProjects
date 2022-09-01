using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDAL.Models
{
    public class Message
    {
        public string MessageId { get; set; }
        public string content { get; set; }
        public string HostID { get; set; }
        public string AuthorName { get; set; }

    }
}
