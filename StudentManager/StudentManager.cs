

class StudentManager
{

    public List<Student> Students { get; set; } = new List<Student>();
    public List<Instructor> Instructors { get; set; } = new List<Instructor>();
    public List<Course> Courses { get; set; } = new List<Course>();


    public bool AddStudent(Student student)
    {

        if (FindStudent(student.StudentId) != null)
        {
            System.Console.WriteLine("The ID Is Duplicated ");
            return false;
        }
        else
        {
            Students.Add(student);

            return true;
        }
    }
    public bool AddCourse(Course course)
    {

        if (FindCourse(course.CourseId) != null)
        {
            System.Console.WriteLine("The ID Is Duplicated ");
            return false;
        }
        else
        {
            Courses.Add(course);

            return true;
        }
    }
    public bool AddInstructor(Instructor instructor)
    {
        if (FindInstructor(instructor.InstructorId) != null)
        {
            System.Console.WriteLine("The ID Is Duplicated ");
            return false;
        }
        else
        {
            Instructors.Add(instructor);

            return true;
        }

    }
    public Student FindStudent(int studentId)
    {
        for (int i = 0; i < Students.Count; i++)
        {
            if (studentId == Students[i].StudentId)
            {

                return Students[i];
            }
        }
        return null;
    }
    public Course FindCourse(int courseId)
    {
        for (int i = 0; i < Courses.Count; i++)
        {
            if (courseId == Courses[i].CourseId)
            {

                return Courses[i];
            }
        }
        return null;
    }
    public Instructor FindInstructor(int instructorId)
    {
        for (int i = 0; i < Instructors.Count; i++)
        {
            if (instructorId == Instructors[i].InstructorId)
            {

                return Instructors[i];
            }
        }
        return null;
    }
    public bool EnrollStudentInCourse(int studentId, int courseId)
    {
        Student student = FindStudent(studentId);
        Course course = FindCourse(courseId);
        if (student == null)
        {
            System.Console.WriteLine("Invalid StudentID");
            return false;
        }
        if (course == null)
        {
            System.Console.WriteLine("Invalid CourseID");
            return false;
        }
        return student.Enroll(course);
    }

}