using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAPI.Services.Models
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public required string Address { get; set; }
    }
}
