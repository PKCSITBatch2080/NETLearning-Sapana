using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CollegeManagerAPI.Controllers
{
    [Route("api/programs")]
    [ApiController]
    public class ProgramController : ControllerBase
    {
        CollegeManagerDb db = new();
        [HttpGet]
        public List<CollegeProgram> Get()
        {
           var programs= db.CollegePrograms.ToList();
            return programs;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            var program = db.CollegePrograms.Find(id);
            if (program == null)
            {
                return NotFound(); 
            }
            return Ok(program);
        }
        [HttpPost]
        public IActionResult Post(CollegeProgram program)   
        {
            db.CollegePrograms.Add(program);
            var rowsAffected = db.SaveChanges();
            if (rowsAffected > 0)
            {
                return CreatedAtAction($"Get",program.Id, program); //status code 201
            }
            else { return BadRequest();}
        }
        [HttpPut]
        public IActionResult Put(CollegeProgram program)   
        {
            db.CollegePrograms.Update(program);
            var rowsAffected = db.SaveChanges();
            return rowsAffected > 0 ? NoContent() : BadRequest();           
        }
         [HttpDelete]
        public IActionResult Delete(CollegeProgram program)   
        {
            db.CollegePrograms.Remove(program);
            var rowsAffected = db.SaveChanges();
            return rowsAffected > 0 ? NoContent() : BadRequest();           
        }

    }
}
