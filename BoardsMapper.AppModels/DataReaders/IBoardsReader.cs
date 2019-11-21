using BoardsMapper.AppModels.Boards;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BoardsMapper.AppModels.DataReaders
{
    public delegate void DataReadCompletedEventHandler(BoardsReadCompletedEventArgs e);
    public interface IBoardsReader
    {
        List<IBoard> Boards { get; }
        IEnumerable<IBoard> ReadData();
        void ReadDataAsync();
        event DataReadCompletedEventHandler DataReadCompleted;
        Task<IEnumerable<IBoard>> ReadData(string address, CancellationToken cancellationToken = default);
    }
}
