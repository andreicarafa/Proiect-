namespace University.Models
{
    public class Grade
    {
        public Guid Id { get; set; }
        public Guid IdCourse { get; set; }
        public Guid IdStudent { get; set; }
        public Guid IdTeacher { get; set; }
        public Guid IdSession { get; set; }
        public int GradeValue {get; set;}
        public DateTime ExamDate {get; set;}

        //Navigation Properties
        public Course? Course {get; set;}
        public Student? Student {get; set;}
        public Teacher? Teacher { get; set; }
        public Session? Session { get; set;}
    }
}

