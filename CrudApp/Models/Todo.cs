namespace CrudApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}
        public TodoStatus Status { get; set; } // New, Inprogress, completed
    }
}
