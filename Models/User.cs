namespace ToDoWeb.Models
{
    public class User
    {
        public int UserId { get; set; } 
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

       
        public ICollection<UserToDo> UserTodos { get; set; } = new List<UserToDo>();
    }
}