using BoardsMapper.AppModels.Boards;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardsMapper.DataManager
{
    public class HtmlWriteParameters : WriteParameters
    {
        public string ApiKey { get; set; }
        public Size MapSize { get; set; }
    }
}
