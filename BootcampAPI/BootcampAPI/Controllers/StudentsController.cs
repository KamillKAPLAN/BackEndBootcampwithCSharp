using BootcampAPI.Models;
using BootcampAPI.Models.TPH;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        private readonly BackEndContext _context;
        //public StudentsController(BackEndContext context)
        public StudentsController()
        {
            //_context = context;
            _context = new BackEndContext();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BankaHesabi>>> GetAllStudent()
        {
            IQueryable<BankaHesabi> students = from student in _context.FaturaDetayis.OfType<BankaHesabi>()
                                           select student;

            return await students.ToListAsync();
        }
    }
}
