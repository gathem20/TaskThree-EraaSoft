class Instructor
{
    public int InstructorId { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }

    public string PrintDetails()
    {
        return $"InstructorId:{InstructorId} Name:{Name} Specialization:{Specialization} ";
    }
}