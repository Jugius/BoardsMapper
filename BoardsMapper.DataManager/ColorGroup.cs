using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardsMapper.DataManager
{
    public class ColorGroup
    {
        private static readonly List<Color> _colors = new List<Color>
        {            
            Color.FromArgb(2, 136, 209),//Blue
            Color.FromArgb(255, 82, 82),//Red
            Color.FromArgb(15, 157, 88),//Green
            Color.FromArgb(156, 39, 176),//Violet
            Color.FromArgb(230, 81, 0),//Orange
            Color.FromArgb(255, 214, 0)//Yellow
        };
        static readonly Random randonGen = new Random();
        public static readonly Color Default = Color.FromArgb(2, 136, 209);
        public string Key { get; }
        public Color Color { get; set; }
        public ColorGroup(string key) : this(key, Default) { }
        public ColorGroup(string key, Color color)
        {
            this.Key = key;
            this.Color = color;
        }

        internal static void SetColors(List<ColorGroup> colorGroups)
        {
            int colorsMaxIndex = _colors.Count - 1;
            for (int i = 0; i < colorGroups.Count; i++)
            {
                if (i <= colorsMaxIndex)
                {
                    colorGroups[i].Color = _colors[i];
                }
                else
                {
                    colorGroups[i].Color = GetRandomColor();
                }
            }
        }
        private static Color GetRandomColor()
        {
            Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));
            return randomColor;
        }

        public static List<Color> GetDefaultColors()
        {
            return _colors;
        }
    }
}
