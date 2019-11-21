using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardsMapper.DataManager
{
    public class DoorsReadParameters
    {
        public string DataPath { get; set; }
        public int Year { get; set; }
        public bool LoadDeleted { get; set; }
        public bool LoadEmpty { get; set; }
    }
}
