using BoardsMapper.AppModels.Boards;

using System.Collections.Generic;

namespace BoardsMapper.DataManager
{
    public abstract class WriteParameters
    {
        public IList<IBoard> Boards { get; set; }
        public ColorsProvider ColorsProvider { get; set; }
    }
}
