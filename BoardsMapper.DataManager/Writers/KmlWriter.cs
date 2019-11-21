using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace BoardsMapper.DataManager.Writers
{
    class KmlWriter : IWriter
    {
        public string Write(WriteParameters parameters)
        {
            KmlWriteParameters p = parameters as KmlWriteParameters;
            var boards = p.Boards;
            if (boards.Count == 0) return null;

            var colors = boards.Select(a => p.ColorsProvider.GetBoardColor(a)).Distinct().ToList();
            var styles = CreateStyles(colors).ToList();

            var document = new Document();
            document.Name = System.IO.Path.GetFileNameWithoutExtension(p.FilePath);

            foreach (var group in boards.GroupBy(a=>a.Address.City))
            {
                Folder f = new Folder();
                f.Name = group.Key;
                foreach (var b in group)
                {
                    var placemark = new Placemark();
                    var c = p.ColorsProvider.GetBoardColor(b);
                    string name = string.IsNullOrEmpty(b.Code) ? (b.Address.ToShortString()) : (b.Code + " " + b.Address.ToShortString());
                    placemark.Name = name;
                    var styleId = styles.First(a => a.Id == $"colorIcon_{c.R}_{c.G}_{c.B}").Id;
                    placemark.StyleUrl = new Uri($"#{styleId}", UriKind.Relative);
                    placemark.Geometry = new SharpKml.Dom.Point
                    {
                        Coordinate = new Vector(b.Location.Latitude, b.Location.Longitude)
                    };

                    string description = $"{b.Type} {b.Size}, сторона {b.Side}";
                    if (b.Metrics != null && b.Metrics.OTS != 0)
                        description += $"<br>OTS: {b.Metrics.OTS} 000, GRP: {b.Metrics.GRP}";
                    description += $"<img src=\"{b.Photo.ToString()}\" height =\"300px\" width=\"auto\"/>";                    
                    description = $"<![CDATA[{description}]]>";
                    placemark.Description = new Description { Text = description };

                    f.AddFeature(placemark);
                }
                document.AddFeature(f);
            }      
            
            foreach (var s in styles)
            {
                document.AddStyle(s);
            }            

            KmlFile kml = KmlFile.Create(document, false);
            KmzFile k = KmzFile.Create(kml);
            
            string path = p.FilePath;
            if (System.IO.File.Exists(path))
                System.IO.File.Delete(path);
            using (var stream = System.IO.File.OpenWrite(path))
            {
                k.Save(stream);
            }

            return path;
        }

        private static IEnumerable<Style> CreateStyles (IEnumerable<Color> colors)
        {
            foreach (var c in colors)
            {
                var style = new Style();
                style.Id = $"colorIcon_{c.R}_{c.G}_{c.B}";
                style.Icon = new IconStyle();
                style.Icon.Color = new Color32(255, c.B, c.G, c.R);
                style.Icon.ColorMode = ColorMode.Normal;
                style.Icon.Icon = new IconStyle.IconLink(new Uri("http://www.gstatic.com/mapspro/images/stock/503-wht-blank_maps.png"));
                style.Icon.Scale = 1;
                style.Label = new LabelStyle();
                style.Label.Scale = 0;
                yield return style;
            }
        }
        
    }
}
