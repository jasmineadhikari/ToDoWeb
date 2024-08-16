namespace ToDoWeb.Models
{
    public class TodoItem
    {
        public int TodoItemId { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }

        
        public ICollection<UserToDo> UserTodos { get; set; } = new List<UserToDo>();
    }
}