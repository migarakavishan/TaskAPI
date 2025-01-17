using System.ComponentModel.DataAnnotations;

namespace TaskAPI.Models
{
    public class Todo
    { 
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public required string Title { get; set; }

        [MaxLength(300)]
        public required string Description { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime Due {  get; set; }

        [Required]
        public TodoStatus Status { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
