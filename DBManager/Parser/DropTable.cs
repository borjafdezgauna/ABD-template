using DbManager.Parser;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbManager
{
    public class DropTable: MiniSqlQuery
    {
        public string Table { get; private set; }

        public DropTable(string table)
        {
            Table = table;
        }

        public string Execute(Database database)
        {
            return null;
        }
    }
}
