using api.Models;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/palette")]
    public class PaletteController : ControllerBase
    {
        private readonly PaletteService _paletteService;

        public PaletteController(PaletteService paletteService)
        {
            _paletteService = paletteService;
        }

        [HttpGet("generate")]
        public ActionResult<Palette> GetRandomPalette()
        {
            var palette = _paletteService.GeneratePalette();

            if(palette == null)
            {
                return NotFound();
            }
                return Ok(palette);
        }
    }
}
