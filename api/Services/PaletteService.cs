using api.Data;
using api.Models;

namespace api.Services
{
    public class PaletteService
    {
        private readonly PaletteData _paletteData;
        public PaletteService(PaletteData paletteData)
        {
            _paletteData = paletteData;
        }

        public Palette GeneratePalette()
        {
            Random random = new Random();

            int index = random.Next(0, _paletteData.PaletteList.Count);
            return _paletteData.PaletteList[index];
        }
    }
}