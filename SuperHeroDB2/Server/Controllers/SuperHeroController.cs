using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroDB.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroDB.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        [HttpGet]

        /*List<Comic> heroes = new List<Comic> {
            new Comic {Name = "Marvel" },
            new Comic {Name = "DC" }
        };

        List<SuperHero> heroes = new List<SuperHero> {
            new SuperHero {FirstName = "Peter", LastName = "Parker", HeroName = "Spiderman"},
            new SuperHero {FirstName = "Bruce" ,LastName = "Wayne", HeroName = "Batman"}
        }; */

        public async Task <ActionResult<List<SuperHero>>> Get()
        {

           
            var heroes = new List<SuperHero>
            {
                new SuperHero{
                ID = 1,
                FirstName = "Peter",
                LastName = "Parker",
                HeroName = "Spiderman",
                Place = "New York"
                },

                new SuperHero{
                ID = 2,
                FirstName = "Bruce",
                LastName = "Wayne",
                HeroName = "Batman",
                Place = "Gotham City"
                },

                 new SuperHero{
                ID = 3,
                FirstName = "Tony",
                LastName = "Stark",
                HeroName = "Iron Man",
                Place = "Long Island"
                },



                 new SuperHero{
                ID = 4,
                FirstName = "Bruce",
                LastName = "Banner",
                HeroName = "Hulk",
                Place = "London"
                },




                 new SuperHero{
                ID = 5,
                FirstName = "Charles",
                LastName = "Xavier",
                HeroName = "Professor X",
                Place = "LA"
                },



                 new SuperHero{
                ID = 6,
                FirstName = "Selina",
                LastName = "Kyle",
                HeroName = "Catwoman",
                Place = "Gotham City"
                }





            };
            return Ok(heroes);

        }
        // Get Call Implementation 

        
    }
}

// Sup[erHero Empty WEB API Controller
// Do not need view support as the view in this is case is the Blaxor wasm Client 