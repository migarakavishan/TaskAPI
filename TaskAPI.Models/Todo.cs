namespace TaskAPI.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime Due {  get; set; }
        public TodoStatus Status { get; set; }

    }
}
