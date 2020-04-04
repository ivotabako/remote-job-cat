﻿using System;
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
    public class RecommendationsController : ControllerBase
    {
        private readonly RemoteJobCatApiContext _context;

        public RecommendationsController(RemoteJobCatApiContext context)
        {
            _context = context;
        }

        // GET: api/Recommendations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recommendation>>> GetRecommendation()
        {
            return await _context.Recommendation.ToListAsync();
        }

        // GET: api/Recommendations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Recommendation>> GetRecommendation(Guid id)
        {
            var recommendation = await _context.Recommendation.FindAsync(id);

            if (recommendation == null)
            {
                return NotFound();
            }

            return recommendation;
        }

        // PUT: api/Recommendations/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecommendation(Guid id, Recommendation recommendation)
        {
            if (id != recommendation.Id)
            {
                return BadRequest();
            }

            _context.Entry(recommendation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecommendationExists(id))
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

        // POST: api/Recommendations
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Recommendation>> PostRecommendation(Recommendation recommendation)
        {
            _context.Recommendation.Add(recommendation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRecommendation", new { id = recommendation.Id }, recommendation);
        }

        // DELETE: api/Recommendations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Recommendation>> DeleteRecommendation(Guid id)
        {
            var recommendation = await _context.Recommendation.FindAsync(id);
            if (recommendation == null)
            {
                return NotFound();
            }

            _context.Recommendation.Remove(recommendation);
            await _context.SaveChangesAsync();

            return recommendation;
        }

        private bool RecommendationExists(Guid id)
        {
            return _context.Recommendation.Any(e => e.Id == id);
        }
    }
}
