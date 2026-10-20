using System.ComponentModel;

class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();
    public string PrintDetails()
    {
        string c = "";
        for (int i = 0; i < Courses.Count; i++)
        {
            c += Courses[i].PrintDetails() + " , ";
        }

        return $"StrudentId: {StudentId} , Name: {Name} , Age: {Age} , Courses {c}";
    }
    public bool Enroll(Course course)
    {
        for (int i = 0; i < Courses.Count; i++)
        {
            if (Courses[i].CourseId == course.CourseId)
            {
                System.Console.WriteLine("You Already Have This Course");
                return false;
            }
        }
        Courses.Add(course);

        return true;
    }

}