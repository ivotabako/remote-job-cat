using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RemoteJobCat.Api.Data;
using RemoteJobCat.Api.Models;

namespace RemoteJobCat.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InternalRecommendationsController : ControllerBase
    {
        private readonly RemoteJobCatApiContext _context;

        public InternalRecommendationsController(RemoteJobCatApiContext context)
        {
            _context = context;
        }

        // GET: api/InternalRecommendations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InternalRecommendation>>> GetInternalRecommendation()
        {
            return await _context.InternalRecommendation.ToListAsync();
        }

        // GET: api/InternalRecommendations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InternalRecommendation>> GetInternalRecommendation(Guid id)
        {
            var internalRecommendation = await _context.InternalRecommendation.FindAsync(id);

            if (internalRecommendation == null)
            {
                return NotFound();
            }

            return internalRecommendation;
        }

        // PUT: api/InternalRecommendations/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInternalRecommendation(Guid id, InternalRecommendation internalRecommendation)
        {
            if (id != internalRecommendation.Id)
            {
                return BadRequest();
            }

            _context.Entry(internalRecommendation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InternalRecommendationExists(id))
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

        // POST: api/InternalRecommendations
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<InternalRecommendation>> PostInternalRecommendation(InternalRecommendation internalRecommendation)
        {
            _context.InternalRecommendation.Add(internalRecommendation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInternalRecommendation", new { id = internalRecommendation.Id }, internalRecommendation);
        }

        // DELETE: api/InternalRecommendations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InternalRecommendation>> DeleteInternalRecommendation(Guid id)
        {
            var internalRecommendation = await _context.InternalRecommendation.FindAsync(id);
            if (internalRecommendation == null)
            {
                return NotFound();
            }

            _context.InternalRecommendation.Remove(internalRecommendation);
            await _context.SaveChangesAsync();

            return internalRecommendation;
        }

        private bool InternalRecommendationExists(Guid id)
        {
            return _context.InternalRecommendation.Any(e => e.Id == id);
        }
    }
}
