using api.Models;

namespace api.Data
{
    public class PaletteData
    {
        public List<Palette> PaletteList => new List<Palette>(_paletteList);
        private readonly List<Palette> _paletteList = new List<Palette>() {
            new Palette { BaseClr = "#F5F5F5", SectionClr = "#FFFFFF", TextClr = "#222222", SecondaryTextClr = "#666666", AccentClr = "#DDDDDD", LineClr = "#6c6390", HoverClr = "#216ec0", ShadowClr = "#1a191a" },
            new Palette { BaseClr = "#0d0f1f", SectionClr = "#1a1d2e", TextClr = "#f0f0fa", SecondaryTextClr = "#a3a6b8", AccentClr = "#5a8dee", LineClr = "#3a3c4a", HoverClr = "#1a1d2e", ShadowClr = "#06070f" },
            new Palette { BaseClr = "#000000", SectionClr = "#111111", TextClr = "#ffffff", SecondaryTextClr = "#bbbbbb", AccentClr = "#00ffff", LineClr = "#ff00ff", HoverClr = "#ff4500", ShadowClr = "#ff1493" },
            new Palette { BaseClr = "#6d5b3f", SectionClr = "#898d3b", TextClr = "#a8eb23", SecondaryTextClr = "#08593a", AccentClr = "#51c747", LineClr = "#d79261", HoverClr = "#f85e00", ShadowClr = "#73b5ad" },
            new Palette { BaseClr = "#3a1a3a", SectionClr = "#502750", TextClr = "#ffe4e1", SecondaryTextClr = "#d4a5b5", AccentClr = "#ff6b6b", LineClr = "#ff7f50", HoverClr = "#ff9966", ShadowClr = "#c94f4f" },
            new Palette { BaseClr = "#f4e4d4", SectionClr = "#fae3e3", TextClr = "#404040", SecondaryTextClr = "#6e6e6e", AccentClr = "#ff9aa2", LineClr = "#ffb7b2", HoverClr = "#ffcbcb", ShadowClr = "#ffdcdc" },
            new Palette { BaseClr = "#16281d", SectionClr = "#1f3824", TextClr = "#e6ffe6", SecondaryTextClr = "#b8d8b8", AccentClr = "#5a9c6d", LineClr = "#3e7351", HoverClr = "#275438", ShadowClr = "#0d2612" },
            new Palette { BaseClr = "#87a14c", SectionClr = "#badec4", TextClr = "#274050", SecondaryTextClr = "#28e75a", AccentClr = "#37275c", LineClr = "#4c9f71", HoverClr = "#b1ff22", ShadowClr = "#cd2084" },
            new Palette { BaseClr = "#d9d3c5", SectionClr = "#5ff569", TextClr = "#5d67b6", SecondaryTextClr = "#74b809", AccentClr = "#caadab", LineClr = "#5ed4df", HoverClr = "#48f73d", ShadowClr = "#9eefb2" },
            new Palette { BaseClr = "#b70b71", SectionClr = "#193a46", TextClr = "#55a5fc", SecondaryTextClr = "#8eb117", AccentClr = "#1572aa", LineClr = "#839d8b", HoverClr = "#8f676c", ShadowClr = "#8df63b" },
            new Palette { BaseClr = "#467a9b", SectionClr = "#946080", TextClr = "#0ad16f", SecondaryTextClr = "#22b3d4", AccentClr = "#bca85d", LineClr = "#f23e92", HoverClr = "#7ca061", ShadowClr = "#bb3067" },
            new Palette { BaseClr = "#282518", SectionClr = "#e3b707", TextClr = "#c97146", SecondaryTextClr = "#bcea9d", AccentClr = "#7e9fbf", LineClr = "#8e4e6f", HoverClr = "#35f754", ShadowClr = "#4b76e7" },
            new Palette { BaseClr = "#ce7fc5", SectionClr = "#e3a0a2", TextClr = "#de06dc", SecondaryTextClr = "#77b2d4", AccentClr = "#69dbb1", LineClr = "#72430a", HoverClr = "#ad695f", ShadowClr = "#be2fc5" },
            new Palette { BaseClr = "#110022", SectionClr = "#220044", TextClr = "#ffffff", SecondaryTextClr = "#ccccff", AccentClr = "#ff00ff", LineClr = "#8800ff", HoverClr = "#6600ff", ShadowClr = "#330055" },
            new Palette { BaseClr = "#fffcf2", SectionClr = "#fff4a3", TextClr = "#333333", SecondaryTextClr = "#b06363", AccentClr = "#ff4500", LineClr = "#ff6a00", HoverClr = "#ff8f00", ShadowClr = "#ffae42" },
            new Palette { BaseClr = "#3b2f2f", SectionClr = "#6a4f4b", TextClr = "#fff5e1", SecondaryTextClr = "#e0c8b2", AccentClr = "#e07a5f", LineClr = "#9d5c50", HoverClr = "#7f4f44", ShadowClr = "#523d3c" },
            new Palette { BaseClr = "#1a1f33", SectionClr = "#25344d", TextClr = "#e4e3f3", SecondaryTextClr = "#b2a7c2", AccentClr = "#4a90e2", LineClr = "#2d4d8c", HoverClr = "#375a99", ShadowClr = "#1a2940" },
            new Palette { BaseClr = "#1e1e1e", SectionClr = "#2a2a2a", TextClr = "#ffffff", SecondaryTextClr = "#b0b0b0", AccentClr = "#4aa3df", LineClr = "#474747", HoverClr = "#333333", ShadowClr = "#d0d0d0" },
            new Palette { BaseClr = "#0d3b66", SectionClr = "#145da0", TextClr = "#f4f4f4", SecondaryTextClr = "#b1d4e0", AccentClr = "#00a8e8", LineClr = "#0077b6", HoverClr = "#005f87", ShadowClr = "#003f5c" },
            new Palette { BaseClr = "#5c9355", SectionClr = "#7b26ed", TextClr = "#b1cd08", SecondaryTextClr = "#f3975a", AccentClr = "#746cd8", LineClr = "#6c6390", HoverClr = "#d343f1", ShadowClr = "#dd531d" },
            new Palette { BaseClr = "#c667d8", SectionClr = "#72f9ba", TextClr = "#f5b0f5", SecondaryTextClr = "#78aacf", AccentClr = "#3a9af5", LineClr = "#1480f1", HoverClr = "#f95655", ShadowClr = "#e566e7" },
            new Palette { BaseClr = "#FAFAFA", SectionClr = "#FFFFFF", TextClr = "#333333", SecondaryTextClr = "#757575", AccentClr = "#E0E0E0", LineClr = "#9E9E9E", HoverClr = "#1976D2", ShadowClr = "#212121" }, 
            new Palette { BaseClr = "#1E1E1E", SectionClr = "#2C2C2C", TextClr = "#E0E0E0", SecondaryTextClr = "#BDBDBD", AccentClr = "#424242", LineClr = "#616161", HoverClr = "#e54210", ShadowClr = "#df9696" }, 
            new Palette { BaseClr = "#FDF6E3", SectionClr = "#EEE8D5", TextClr = "#586E75", SecondaryTextClr = "#657B83", AccentClr = "#93A1A1", LineClr = "#268BD2", HoverClr = "#CB4B16", ShadowClr = "#073642" }, 
            new Palette { BaseClr = "#002B36", SectionClr = "#073642", TextClr = "#839496", SecondaryTextClr = "#93A1A1", AccentClr = "#586E75", LineClr = "#B58900", HoverClr = "#2AA198", ShadowClr = "#002B36" },   
            new Palette { BaseClr = "#FCE4EC", SectionClr = "#F8BBD0", TextClr = "#880E4F", SecondaryTextClr = "#AD1457", AccentClr = "#F06292", LineClr = "#E91E63", HoverClr = "#D81B60", ShadowClr = "#6A1B9A" },    
            new Palette { BaseClr = "#F1F8E9", SectionClr = "#DCEDC8", TextClr = "#33691E", SecondaryTextClr = "#558B2F", AccentClr = "#A5D6A7", LineClr = "#8BC34A", HoverClr = "#689F38", ShadowClr = "#2E7D32" }, 
            new Palette { BaseClr = "#212121", SectionClr = "#424242", TextClr = "#E0E0E0", SecondaryTextClr = "#BDBDBD", AccentClr = "#757575", LineClr = "#9E9E9E", HoverClr = "#448AFF", ShadowClr = "#0D47A1" }, 
            new Palette { BaseClr = "#ECEFF1", SectionClr = "#CFD8DC", TextClr = "#37474F", SecondaryTextClr = "#455A64", AccentClr = "#B0BEC5", LineClr = "#90A4AE", HoverClr = "#00ACC1", ShadowClr = "#263238" }, 
            new Palette { BaseClr = "#FFF3E0", SectionClr = "#FFE0B2", TextClr = "#E65100", SecondaryTextClr = "#F57C00", AccentClr = "#FFB74D", LineClr = "#FB8C00", HoverClr = "#FF6D00", ShadowClr = "#BF360C" }, 
            new Palette { BaseClr = "#ECEFF1", SectionClr = "#FFFFFF", TextClr = "#37474F", SecondaryTextClr = "#546E7A", AccentClr = "#B0BEC5", LineClr = "#90A4AE", HoverClr = "#00ACC1", ShadowClr = "#263238" },
            new Palette { BaseClr = "#E3F2FD", SectionClr = "#BBDEFB", TextClr = "#0D47A1", SecondaryTextClr = "#1976D2", AccentClr = "#64B5F6", LineClr = "#42A5F5", HoverClr = "#1E88E5", ShadowClr = "#0D47A1" }, 
            new Palette { BaseClr = "#FFEBEE", SectionClr = "#FFCDD2", TextClr = "#C62828", SecondaryTextClr = "#E53935", AccentClr = "#EF5350", LineClr = "#D32F2F", HoverClr = "#B71C1C", ShadowClr = "#7F0000" }, 
            new Palette { BaseClr = "#FFFDE7", SectionClr = "#FFF9C4", TextClr = "#F57F17", SecondaryTextClr = "#F9A825", AccentClr = "#FFEE58", LineClr = "#FBC02D", HoverClr = "#F57C00", ShadowClr = "#E65100" }, 
            new Palette { BaseClr = "#ECEFF1", SectionClr = "#CFD8DC", TextClr = "#263238", SecondaryTextClr = "#37474F", AccentClr = "#90A4AE", LineClr = "#546E7A", HoverClr = "#00838F", ShadowClr = "#102027" }, 
            new Palette { BaseClr = "#212121", SectionClr = "#303030", TextClr = "#F5F5F5", SecondaryTextClr = "#E0E0E0", AccentClr = "#757575", LineClr = "#9E9E9E", HoverClr = "#D84315", ShadowClr = "#1B0000" }, 
            new Palette { BaseClr = "#EFEBE9", SectionClr = "#D7CCC8", TextClr = "#3E2723", SecondaryTextClr = "#5D4037", AccentClr = "#8D6E63", LineClr = "#795548", HoverClr = "#6D4C41", ShadowClr = "#3E2723" }, 
            new Palette { BaseClr = "#E8F5E9", SectionClr = "#C8E6C9", TextClr = "#1B5E20", SecondaryTextClr = "#2E7D32", AccentClr = "#66BB6A", LineClr = "#43A047", HoverClr = "#388E3C", ShadowClr = "#1B5E20" }, 
            new Palette { BaseClr = "#EDE7F6", SectionClr = "#D1C4E9", TextClr = "#311B92", SecondaryTextClr = "#512DA8", AccentClr = "#9575CD", LineClr = "#673AB7", HoverClr = "#5E35B1", ShadowClr = "#311B92" }, 
            new Palette { BaseClr = "#FFFBFA", SectionClr = "#FBE9E7", TextClr = "#BF360C", SecondaryTextClr = "#D84315", AccentClr = "#FF7043", LineClr = "#E64A19", HoverClr = "#D84315", ShadowClr = "#4E342E" }, 
            new Palette { BaseClr = "#F3E5F5", SectionClr = "#E1BEE7", TextClr = "#6A1B9A", SecondaryTextClr = "#8E24AA", AccentClr = "#AB47BC", LineClr = "#9C27B0", HoverClr = "#7B1FA2", ShadowClr = "#4A148C" }
        };
    }
}
