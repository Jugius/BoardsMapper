using BoardsMapper.AppModels.Boards;
using BoardsMapper.AppModels.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardsMapper.DataManager
{
    internal class Board_Doors : IBoard
    {
        #region Interface implementation
        public string ID => this.Dix.ToString();
        public string Supplier { get; }
        public string Code { get; }
        public BoardAddress Address { get; }
        public string Side { get; }
        public string Size { get; }
        public string Type { get; }
        public bool Lighting { get; }
        public BoardMetrics Metrics { get; }
        public Uri Photo { get; }
        public Uri Map { get; }
        public Location Location { get; }
        public string Provider { get; }
        //public bool IsChecked { get; set; }

        #endregion
        internal readonly int Dix;
        internal readonly bool IsDeleted;
        //public bool Deleted { get; }
        //public string PlaceCity { get; }
        //public int D_ID { get; }
        //public int CityID { get; }

        internal Board_Doors(DoorsDataSet.NosDataTableRow row)
        {
            this.Dix = row.id;
            this.Supplier = row.supplier.Trim();
            this.Code = row.code.Trim();
            this.Address = new BoardAddress
            {
                City = row.city.Trim(),
                Description = row.description.Trim(),
                District = null,
                Region = null,
                Street = row.street.Trim(),
                StreetNumber = row.streetnumber.Trim()
            };
            this.IsDeleted = row.deleted;
            this.Side = row.side;
            this.Size = row.size;
            this.Type = row.type.Trim();
            this.Lighting = (int)row.lighting == 0 ? false : true;
            this.Metrics = new BoardMetrics { OTS = (int)row.ots, GRP = (float)row.grp };
            this.Location = new Location((double)row.latitude, (double)row.longitude);
            this.Provider = "Infopanel";

            this.Photo = new Uri(@"http://www.doors-c.com.ua/pict/PHOTOS/" + row.cityshort + @"/" + $"{row.d_id}_{row.id}.jpg");
            this.Map = new Uri(@"http://www.doors-c.com.ua/pict/SHEM/" + row.cityshort + @"/" + $"{row.id}.jpg");
        }
    }
}
