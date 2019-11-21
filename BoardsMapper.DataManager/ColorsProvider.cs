using BoardsMapper.AppModels.Boards;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;


namespace BoardsMapper.DataManager
{
    public class ColorsProvider
    {
        public enum GroupingBy { City, Supplier, Size, Kind, Default }
        private Func<IBoard, string> KeySelector { get; }
        public GroupingBy GroupKey { get; set; }
        public List<ColorGroup> ColorGroups { get; set; } 

        private ColorsProvider(Func<IBoard, string> keySelector)
        {
            this.KeySelector = keySelector;
        }
        public Color GetBoardColor(IBoard board)
        {
            if (this.KeySelector == null) return ColorGroups.First().Color;

            string keyValue = this.KeySelector(board);
            var colorGroup = this.ColorGroups.FirstOrDefault(a => a.Key == keyValue);
            return colorGroup?.Color ?? ColorGroup.Default;
        }
        private static ColorsProvider Create(GroupingBy grouping)
        {
            switch (grouping)
            {
                case GroupingBy.City: return new ColorsProvider(new Func<IBoard, string>(a => a.Address.City));
                case GroupingBy.Supplier: return new ColorsProvider(new Func<IBoard, string>(a => a.Supplier));
                case GroupingBy.Size: return new ColorsProvider(new Func<IBoard, string>(a => a.Size));
                case GroupingBy.Kind: return new ColorsProvider(new Func<IBoard, string>(a => a.Type));
                default: return new ColorsProvider(null);
            }
        }
        public static ColorsProvider Create(GroupingBy grouping, IEnumerable<IBoard> boards)
        {
            ColorsProvider c = Create(grouping);
            c.GroupKey = grouping;

            if (grouping == GroupingBy.Default)
            {
                c.ColorGroups = new List<ColorGroup> { new ColorGroup("Цвет по умолчанию") };
            }
            else
            {
                c.ColorGroups = boards.GroupBy(c.KeySelector).Select(a => new ColorGroup(a.Key)).ToList();
                ColorGroup.SetColors(c.ColorGroups);
            }
            return c;
        }
    }
}
