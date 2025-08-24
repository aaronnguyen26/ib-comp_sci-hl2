public class StudentModel : PersonModel
{
    public int GradeLevel { get; set; }
    public int DistrictStudentID { get; set; }

    public string Email { get; set; }

    public override string ToString()
    {
        string output;
        output = $"{FirstName}, {LastName}\nGrade: {GradeLevel}, Age: {Age}";
        return output;
    }


}
