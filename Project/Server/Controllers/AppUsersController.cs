using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Server.IRepository;
using Project.Shared.Domain;

namespace Project.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AppUsersController(IUnitOfWork unitOfWOrk)
        {
            _unitOfWork = unitOfWOrk;
        }

        // GET: api/AppUsers
        [HttpGet]
        public async Task<IActionResult> GetAppUsers()
        {
            var appUsers = await _unitOfWork.AppUsers.GetAll();
            return Ok(appUsers);
        }

        // GET: api/AppUsers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppUser(int id)
        {
            var appUser = await _unitOfWork.AppUsers.Get(q => q.Id == id);

            if (appUser == null)
            {
                return NotFound();
            }

            return Ok(appUser);
        }

        // PUT: api/AppUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppUser(int id, AppUser appUser)
        {
            if (id != appUser.Id)
            {
                return BadRequest();
            }

            _unitOfWork.AppUsers.Update(appUser);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await AppUserExists(id))
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

        // POST: api/AppUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AppUser>> PostAppUser(AppUser appUser)
        {
            await _unitOfWork.AppUsers.Insert(appUser);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAppUser", new { id = appUser.Id }, appUser);
        }

        // DELETE: api/AppUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppUser(int id)
        {
            var appUser = await _unitOfWork.AppUsers.Get(q => q.Id == id);
            if (appUser == null)
            {
                return NotFound();
            }

            await _unitOfWork.AppUsers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> AppUserExists(int id)
        {
            var appUser = await _unitOfWork.AppUsers.Get(q => q.Id == id);
            return appUser != null;
        }
    }
}
