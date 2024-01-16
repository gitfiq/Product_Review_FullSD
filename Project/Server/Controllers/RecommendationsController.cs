using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Server.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Server.Data;
using Project.Shared.Domain;
using System.Drawing;

namespace Project.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommendationsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public RecommendationsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Recommendations
        [HttpGet]
        public async Task<IActionResult> GetRecommendations()
        {

            var recommendations = await _unitOfWork.Recommendations.GetAll();
            return Ok(recommendations);
        }

        // GET: api/Recommendations/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRecommendation(int id)
        {

            var recommendation = await _unitOfWork.Recommendations.Get(q => q.RecommendationId == id);

            if (recommendation == null)
            {
                return NotFound();
            }

            return Ok(recommendation);
        }

        // PUT: api/Recommendations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecommendation(int id, Recommendation recommendation)
        {
            if (id != recommendation.RecommendationId)
            {
                return BadRequest();
            }

            _unitOfWork.Recommendations.Update(recommendation);


            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await RecommendationExists(id))
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
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Recommendation>> PostRecommendation(Recommendation recommendation)
        {

            await _unitOfWork.Recommendations.Insert(recommendation);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRecommendation", new { id = recommendation.RecommendationId }, recommendation);
        }

        // DELETE: api/Recommendations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecommendation(int id)
        {
            var recommendation = await _unitOfWork.Recommendations.Get(q => q.RecommendationId == id);

            if (recommendation == null)
            {
                return NotFound();
            }

            await _unitOfWork.Recommendations.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> RecommendationExists(int id)
        {
            var recommendation = await _unitOfWork.Recommendations.Get(q => q.RecommendationId == id);
            return recommendation != null;
        }
    }
}
