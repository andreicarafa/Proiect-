namespace University.Models
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public Guid Email { get; set;}
        public string? DidacticRole {get; set;}
        
        //Navigation Properties
        public User? User { get; set; }
    }
}