using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BootcampAPI.Models;

namespace BootcampAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAddressesController : ControllerBase
    {
        private readonly BackEndContext _context;

        public StudentAddressesController()
        {
            _context = new BackEndContext();
        }

        // GET: api/StudentAddresses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentAddress>>> GetStudentAddresses()
        {
            return await _context.StudentAddresses.ToListAsync();
        }

        // GET: api/StudentAddresses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentAddress>> GetStudentAddress(int id)
        {
            var studentAddress = await _context.StudentAddresses.FindAsync(id);

            if (studentAddress == null)
            {
                return NotFound();
            }

            return studentAddress;
        }

        // PUT: api/StudentAddresses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentAddress(int id, StudentAddress studentAddress)
        {
            if (id != studentAddress.StudentAddressId)
            {
                return BadRequest();
            }

            _context.Entry(studentAddress).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentAddressExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/StudentAddresses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StudentAddress>> PostStudentAddress(StudentAddress studentAddress)
        {
            _context.StudentAddresses.Add(studentAddress);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StudentAddressExists(studentAddress.StudentAddressId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStudentAddress", new { id = studentAddress.StudentAddressId }, studentAddress);
        }

        // DELETE: api/StudentAddresses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudentAddress(int id)
        {
            var studentAddress = await _context.StudentAddresses.FindAsync(id);
            if (studentAddress == null)
            {
                return NotFound();
            }

            _context.StudentAddresses.Remove(studentAddress);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentAddressExists(int id)
        {
            return _context.StudentAddresses.Any(e => e.StudentAddressId == id);
        }
    }
}
