using Microsoft.AspNetCore.Mvc;
using SpermListTest1.data.entites;
using SpermListTest1.Model;
using SpermListTest1.Model.FilterModels;
using SpermListTest1.Services;
using SpermListTest1.Services.FilterServices;

namespace SpermListTest1.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class SpermsController : Controller
    {
        private readonly SpermServices _SpermsServices;
        private readonly CsvImportToDb _CsvImport;
        private readonly filterServices _filterServices;
        public SpermsController(SpermServices spermsServices, CsvImportToDb csvImport,filterServices filterServices)
        {
            _SpermsServices = spermsServices;
            _CsvImport = csvImport;
            _filterServices = filterServices;
        }



        [HttpGet]
        public IActionResult SpermList()
        {
            var result = _SpermsServices.SpermList();
            return Ok(result);
        }

        [HttpGet]
        public IActionResult ImportToDb(string fileName)
        {
            _CsvImport.ImportToDb(fileName);
            return Ok("data saved succesfully"); 
        }

        [HttpGet]
        public IActionResult FilteredList([FromQuery] FilterModel filterModel)
        {

            var result = _filterServices.SearchFilter(filterModel);
            
            return Ok(result);
            
        }

        
    }
}
