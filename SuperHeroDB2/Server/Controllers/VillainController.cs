using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SuperHeroDB.Shared;


namespace SuperHeroDB.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillainController : Controller
    {
        private object _context;

        [HttpGet]


        public async Task<ActionResult<List<Villain>>> GetVillains()
        {


            var villains = new List<Villain>
            {
                new Villain{
                ID = 1,
                FirstName = "Wilson",
                LastName = "Fisk",
                VillainName = "KingPin",
                Place = "New York"
                },

                new Villain{
                ID = 2,
                FirstName = "Otto",
                LastName = "Octavius",
                VillainName = "Doctor Octupus",
                Place = "New York"
                },

                 new Villain{
                ID = 3,
                FirstName = "Jack",
                LastName = "Napier",
                VillainName = "The Joker",
                Place = "Gotham City"
                },



                 new Villain{
                ID = 4,
                FirstName = "Alexander ",
                LastName = "Luthor",
                VillainName = "Lex Luthor",
                Place = "Metroplois"
                }










            };
            return Ok(villains);

            
            //[HttpGet("{ID}")]

            //public async Task<ActionResult<Villain>> GetSingleVillain(int ID)
            //{
            //    var villain = await _context.Villain
            //        .Include(h => h.Villain)
            //        .FirstOrDefaultAsync(h => h.Id == ID);
            //    if (villain == null)
            //    {
            //        return NotFound("Sorry, no villain here. :/");
            //    }
           //     return Ok(villain);
           // }
        }

    }
}
