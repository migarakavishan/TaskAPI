using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services.Models
{
    public class TodoDto
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public required string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime Due { get; set; }

        public required string Status { get; set; }

        public int AuthorId { get; set; }
        
    }
}
