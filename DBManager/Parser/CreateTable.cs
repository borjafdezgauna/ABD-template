using System;
using System.Collections.Generic;
using System.Text;
using DbManager.Parser;

namespace DbManager
{
 
    public class CreateTable : MiniSqlQuery
    {
        public string Table { get; private set; }
        public List<ColumnParameters> ColumnsParameters { get; private set; } = new List<ColumnParameters>();

        public CreateTable(string pTable, List<ColumnParameters> columns)
        {
            Table = pTable;
            ColumnsParameters = columns;
        }
        public string Execute(Database database)
        {
            return null;
        }

    }
}
