using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Server.IRepository;
using Project.Shared.Domain;

namespace Project.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookAuthorDetailsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookAuthorDetailsController(IUnitOfWork unitOfWOrk)
        {
            _unitOfWork = unitOfWOrk;
        }

        // GET: api/BookAuthorDetails
        [HttpGet]
        public async Task<IActionResult> GetBookAuthorDetails()
        {
            var bookAuthorDetails = await _unitOfWork.BookAuthorDetails.GetAll(includes: q => q.Include(x => x.Book).Include(x => x.Author));
            return Ok(bookAuthorDetails);
        }

        // GET: api/BookAuthorDetails/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookAuthorDetail(int id)
        {
            var bookAuthorDetail = await _unitOfWork.BookAuthorDetails.Get(q => q.Id == id);

            if (bookAuthorDetail == null)
            {
                return NotFound();
            }

            return Ok(bookAuthorDetail);
        }

        // PUT: api/BookAuthorDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookAuthorDetail(int id, BookAuthorDetail bookAuthorDetail)
        {
            if (id != bookAuthorDetail.Id)
            {
                return BadRequest();
            }

            _unitOfWork.BookAuthorDetails.Update(bookAuthorDetail);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await BookAuthorDetailExists(id))
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

        // POST: api/BookAuthorDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookAuthorDetail>> PostBookAuthorDetail(BookAuthorDetail bookAuthorDetail)
        {
            await _unitOfWork.BookAuthorDetails.Insert(bookAuthorDetail);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBookAuthorDetail", new { id = bookAuthorDetail.Id }, bookAuthorDetail);
        }

        // DELETE: api/BookAuthorDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookAuthorDetail(int id)
        {
            var bookAuthorDetail = await _unitOfWork.BookAuthorDetails.Get(q => q.Id == id);
            if (bookAuthorDetail == null)
            {
                return NotFound();
            }

            await _unitOfWork.BookAuthorDetails.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> BookAuthorDetailExists(int id)
        {
            var bookAuthorDetail = await _unitOfWork.BookAuthorDetails.Get(q => q.Id == id);
            return bookAuthorDetail != null;
        }
    }
}
