using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Burgurr.Data;

namespace Burgurr.Controllers;

[Route("burgers")]
[ApiController]
public class BurgersController : Controller
{
    private readonly BurgerStoreContext _db;

    public BurgersController(BurgerStoreContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<Burger>>> GetBurgers()
    {
        return (await _db.Burgers.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
    }
}
