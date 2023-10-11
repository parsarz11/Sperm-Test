using Microsoft.AspNetCore.Mvc;
using SpermListTest1.Services;

namespace SpermListTest1.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class SpermsController : Controller
    {
        private readonly SpermServices _SpermsServices;
        private readonly CsvImportToDb _CsvImport;

        public SpermsController(SpermServices spermsServices, CsvImportToDb csvImport)
        {
            _SpermsServices = spermsServices;
            _CsvImport = csvImport;
        }



        [HttpGet]
        public IActionResult SpermList()
        {
            //var result = _CsvImport.ImportToDb();
            return Ok();
        }

        [HttpGet]
        public IActionResult ImportToDb(string fileName)
        {
            _CsvImport.ImportToDb(fileName);
            return Ok("data saved succesfully"); 
        }

        [HttpGet]
        public IActionResult FilteredList()
        {
            return Ok();
        }
    }
}
