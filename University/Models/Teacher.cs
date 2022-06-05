namespace University.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string? Email { get; set;}
        public string? DidacticRole {get; set;}
        
        //Navigation Properties
        public User? User { get; set; }
    }
}