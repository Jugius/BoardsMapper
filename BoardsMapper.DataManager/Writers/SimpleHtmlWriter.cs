using BoardsMapper.AppModels.Maps;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace BoardsMapper.DataManager.Writers
{
    internal class SimpleHtmlWriter : IHtmlWriter
    {
        public string Write(WriteParameters parameters)
        {
            HtmlWriteParameters p = parameters as HtmlWriteParameters;
            var boards = p.Boards;
            if (boards.Count == 0) return null;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("var sites = [");
            foreach (var b in boards)
            {
                Color c = p.ColorsProvider.GetBoardColor(b);
                sb.Append("[");
                sb.Append(b.Location.ToString()).Append(",");
                sb.Append("'<div style=\"text-align:center\">").Append($"<br><img src=\"{b.Photo.ToString()}\" width=\"384\" height=\"288\"><br>").Append("</div>'").Append(",");
                sb.Append($"\"Rgb({c.R},{c.G},{c.B})\"").AppendLine("],");
            }
            sb.AppendLine("];");
            string markers = sb.ToString();
            Location center = GetMapCenter(boards.Select(a => a.Location));
            string mapsize = $"<div id = \"map_canvas\" style = \"width: {p.MapSize.Width}px; height: {p.MapSize.Height-10}px;\"></div>";

            string html = Properties.Resources.SimpleHtmlPage;
            html = html.Replace("point_apikey_to_insert", p.ApiKey);
            html = html.Replace("point_boards_to_insert", markers);
            html = html.Replace("point_mapcenter_to_insert", center.ToString());
            html = html.Replace("point_mapsize_to_insert", mapsize);

            return html;
        }
        internal static Location GetMapCenter(IEnumerable<Location> points)
        {
            var minLat = points.Min(a => a.Latitude);
            var maxLat = points.Max(a => a.Latitude);
            var midLat = minLat == maxLat ? minLat : (minLat + maxLat) / 2;

            var minLon = points.Min(a => a.Longitude);
            var maxLon = points.Max(a => a.Longitude);
            var midLon = minLon == maxLon ? minLon : (minLon + maxLon) / 2;

            return new Location(midLat, midLon);
        }
    }
}
