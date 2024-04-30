public class Students{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Address { get; set; }
    public DateTime Dob { get; set; }
    //college progrom to student 1-M relation
    public int CollegeProgramId { get; set; }
    public CollegeProgram? CollegeProgram { get; set; }


}