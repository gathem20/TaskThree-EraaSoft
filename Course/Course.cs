class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }
    public Instructor Instructor { get; set; }
      public string PrintDetails()
    {
        return $"CourseID:{CourseId} Title:{Title} Instructor:{Instructor.PrintDetails()} ";
    }
}



