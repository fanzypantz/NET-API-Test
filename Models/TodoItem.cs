using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoTest.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
    }
}
