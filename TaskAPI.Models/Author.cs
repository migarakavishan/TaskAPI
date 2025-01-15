using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAPI.Models
{
    public class Author
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
    }
}
