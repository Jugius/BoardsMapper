using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Linq;
using BoardsMapper.AppModels.Boards;
using Ookii.Dialogs;

namespace BoardsMapper.DataManager.Readers
{
    class DoorsReader : IProcessor
    {
        public string ConnectionString { get; }
        public string Year { get; }
        public DoorsReader(string connectionString, int databaseYear)
        {
            this.ConnectionString = connectionString;
            this.Year = databaseYear.ToString();
        }
        public void StartProcess(ProgressDialog dialog, DoWorkEventArgs e)
        {
            DoorsDataSet.NosDataTableDataTable table = new DoorsDataSet.NosDataTableDataTable();
            string dbName = $"_{Year}nos";

            string query = $"SELECT {dbName}.city, {dbName}.type, {dbName}.owner AS Supplier, {dbName}.snjt AS Deleted, {dbName}.x AS Longitude, {dbName}.y AS Latitude, {dbName}.streets AS Street, {dbName}.house AS StreetNumber, {dbName}.looc AS Description, " +
                           $"{dbName}.number AS Code, {dbName}.ots, {dbName}.ndex AS GRP, {dbName}.dix AS ID, {dbName}.storona AS Side, {dbName}.`size`, {dbName}.d_id, {dbName}.lighting, cities.short_nam AS CityShort " +
                           $"FROM _{Year}nos, cities " +
                           $"WHERE _{Year}nos.n_city = cities.id_city";

            using (var con = new OleDbConnection(ConnectionString))
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(table);
                con.Close();
            }
            var boards = table.Where(a => !a.deleted).Select(a => new Board_Doors(a)).Where(a => !string.IsNullOrEmpty(a.Address.Street)).DistinctBy(a => a.ID);
            if (e.Argument == null)
            {
                e.Result = boards.Select(a => a as IBoard).ToList();
            }
            else
            {
                int[] arr = e.Argument as int[];
                HashSet<int> hs = new HashSet<int>(arr);
                e.Result = boards.Where(a => hs.Contains(a.Dix)).Select(a=>a as IBoard).ToList();
            }
        }
    }
}
