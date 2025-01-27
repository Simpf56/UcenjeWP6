using EdunovaAPP.Data;
using Microsoft.AspNetCore.Mvc;

namespace EdunovaAPP.Controllers
{
        [ApiController]
    [Route("api/v1/[controller]")]
    public class SmjerController : ControllerBase
    {
        // koristimo dependency injection
        //  1. Definiramo privatno svojstvo
        private readonly EdunovaContext _context;

        // koristimo dependency injection
        // 2. proslijedis instancu kroz kronstruktor

        public SmjerController(EdunovaContext context)
        {
            _context = context;
        }




        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Smjerovi);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        }
    }
