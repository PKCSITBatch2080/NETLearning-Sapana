using Microsoft.AspNetCore.Mvc;

public class ProgramController : Controller
{
    List <CollegeProgram> programs = 
    [
        new() { Id = 1, Name = "CSIT", Affiliation="TU", StartedDate=DateTime.Now},
        new() { Id = 2, Name = "BIM", Affiliation="PU", StartedDate=DateTime.Now.AddYears(-2)},
        new(){ Id = 4, Name = "BIT", Affiliation="TU", StartedDate=DateTime.Now.AddDays(-200)},
        new(){ Id = 4, Name = "BBA", Affiliation="TU", StartedDate=DateTime.Now.AddDays(-2000)},

    ];
    public IActionResult Index()
    {  
        return View(programs); // program ko data view lai pathaideko
    }

    [HttpGet]
    public IActionResult Add() 
    {
        return View(); 
    }
    [HttpPost] //C# attribute
    public IActionResult Add(CollegeProgram program) //Model binding ->
    //college program uta bata aauxa vanni inform gareko
    {
        //do something on program
        programs.Add(program);
        return RedirectToAction("Index"); //response code is 3xx
    }

}