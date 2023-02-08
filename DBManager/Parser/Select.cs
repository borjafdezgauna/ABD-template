using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManager 
{
    public class Select: MiniSqlQuery
    {
        public string Table { get; private set; }
        public List<string> Columns { get; private set; }
        public Parser.Condition Where { get; private set; }

        public Select(string table, List<string> columns, Parser.Condition where=null)
        {
            Table = table;
            Columns = columns;
            Where = where;
        }

        public string Execute(Database database)
        {
            return null;            
        }
    }
}
