using api.Data;
using api.Models;
using api.Services;

namespace apiTest
{
    public class PaletteServiceTest
    {
        private readonly PaletteService _paletteService;
        private readonly PaletteData _paletteData;

        public PaletteServiceTest()
        {
            _paletteData = new PaletteData();
            _paletteService = new PaletteService(_paletteData);
        }

        [Fact]
        public void ShouldReturnRandomPalette() 
        {
            HashSet<int> Indexes = new HashSet<int>();

            for(int i = 0; i < 1000; i++)
            {
                int index = _paletteData.PaletteList.IndexOf(_paletteService.GeneratePalette());
                Indexes.Add(index);
            }

            Assert.True(Indexes.SetEquals(Enumerable.Range(0, _paletteData.PaletteList.Count)));
        }

        //Thought note: Due to the nature of randomness, this test may fail sometimes.
        //I could've made made it run until it passes, but what if it never passes due to error?
        //How to make a test for random that doesn't fail, but doesn't potentially enter an infinite loop?
        //Even if you set a timeout, there's still the potential for failure.
        //Set the interation limit to list.Count, and as each item appears, remove the item at its index without altering the other elements appropriate index?
        //I'll be back to tackle this.

        [Fact]
        public void ShouldNotReturnNullorEmpty()
        {
            Assert.All(_paletteData.PaletteList, palette => {
                Assert.NotNull(palette.BaseClr);
                Assert.NotNull(palette.SectionClr);
                Assert.NotNull(palette.TextClr);
                Assert.NotNull(palette.SecondaryTextClr);
                Assert.NotNull(palette.AccentClr);
                Assert.NotNull(palette.HoverClr);
                Assert.NotNull(palette.ShadowClr);
            });
        }

        [Fact]
        public void ShouldNotHaveDuplicatePalette()
        {
            var duplicates = _paletteData.PaletteList
        .GroupBy(p => new { p.BaseClr, p.LineClr, p.HoverClr, p.TextClr, p.AccentClr, p.SecondaryTextClr })
        .Where(g => g.Count() > 1);

            Assert.Empty(duplicates);
        }
    }
}