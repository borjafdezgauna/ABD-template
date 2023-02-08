using DbManager.Parser;
using System.Collections.Generic;

namespace DbManager
{
    public class Update: MiniSqlQuery
    {
        public string Table { get; private set; }
        public List<SetValue> Columns { get; private set; }
        public Condition Where { get; private set; }

        public Update(string table, List<SetValue> columnNames, Condition where)
        {
            Table = table;
            Columns = columnNames;
            Where = where;
        }

        public string Execute(Database database)
        {
            return null;
        }

       
    }
}