using Microsoft.AspNetCore.Mvc;

public class ProgramController : Controller
{
    public IActionResult Index()
    {  
        CollegeManagerDb db = new();
        var models = db.CollegePrograms.ToList();
        return View(models); // models ko data view lai pathaideko
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
         CollegeManagerDb db = new();
        db.CollegePrograms.Add(program); // yaha data insert garni query
        db.SaveChanges();
        return RedirectToAction("Index"); //response code is 3xx
    }
     [HttpGet]
    public IActionResult Edit(int id)
    {
        CollegeManagerDb db = new();
        var model = db.CollegePrograms.Find(id);
        return View(model);
    }

    [HttpPost]
    public IActionResult Edit(CollegeProgram program) 
    {
        CollegeManagerDb db = new();
        db.CollegePrograms.Update(program);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        CollegeManagerDb db = new();
        var program = db.CollegePrograms.Find(id);

	    if (program != null)
	    {
            db.CollegePrograms.Remove(program);
            db.SaveChanges();
         }
	return RedirectToAction("Index");
}


}