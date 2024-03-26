using Microsoft.AspNetCore.Mvc;

public class ProgramController : Controller
{
    public IActionResult Index()
    { 
        CollegeProgram c1 = new() { Id = 1, Name = "CSIT", Affiliation="TU", StartedDate=DateTime.Now};
        CollegeProgram c2 = new() { Id = 2, Name = "BIM", Affiliation="PU", StartedDate=DateTime.Now.AddYears(-2)};
        CollegeProgram c3 = new() { Id = 3, Name = "BCA", Affiliation="TU", StartedDate=DateTime.Now.AddMonths(-11)};
        CollegeProgram c4 = new() { Id = 4, Name = "BIT", Affiliation="TU", StartedDate=DateTime.Now.AddDays(-200)};

        List <CollegeProgram> programs = new() { c1, c2, c3, c4 };
        
        return View(programs); // view is a method of that class

    }
}