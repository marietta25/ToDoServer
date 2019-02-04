using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoServer.Models
{
    public class Task
    {
        public int? Id { get; set; }
        public string OwnerId { get; set; }

        public string Title { get; set; }
        public string Desc { get; set; }
        public bool MarkedAsDone { get; set; } = false;
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
    }
}
