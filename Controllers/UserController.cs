using Microsoft.AspNetCore.Mvc;
using SureMan.Model;
//using SureMan.
namespace SureMan.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        // GET api/customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetCustomer(int id)
        {
            var customer = await _context.Users.FindAsync(id);

            if (customer == null)
                return NotFound();

            return customer;
        }

    }
    //[Route("api/[controller]")]
    //[ApiController]
    //public class AuthController : ControllerBase
    //{
    //    private readonly AppDbContext _db;
    //    public AuthController(AppDbContext db) { _db = db; }

    //    [HttpPost("register")]
    //    public async Task<IActionResult> Register([FromBody] RegisterDto dto)
    //    {
    //        if (string.IsNullOrWhiteSpace(dto.Name) ||
    //            string.IsNullOrWhiteSpace(dto.Email) ||
    //            string.IsNullOrWhiteSpace(dto.Password))
    //            return BadRequest(new { message = "All fields are required." });

    //        var exists = await _db.Users.AnyAsync(u => u.Email == dto.Email);
    //        if (exists) return BadRequest(new { message = "Email already registered." });

    //        var user = new User
    //        {
    //            FullName = dto.Name,
    //            Email = dto.Email,
    //            Password = BCrypt.Net.BCrypt.HashPassword(dto.Password)
    //        };

    //        _db.Users.Add(user);
    //        await _db.SaveChangesAsync();

    //        return Ok(new { message = "User registered successfully." });
    //    }
    //}
}
