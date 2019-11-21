using System;

namespace BoardsMapper.AppModels.Boards
{
    public interface IBoard
    {
        string ID { get; }
        string Supplier { get; }
        string Code { get; }
        BoardAddress Address { get; }
        Maps.Location Location { get; }
        string Side { get; }
        string Size { get; }
        string Type { get; }
        bool Lighting { get; }
        BoardMetrics Metrics { get; }
        Uri Photo { get; }
        Uri Map { get; }
        string Provider { get; }
    }
}
