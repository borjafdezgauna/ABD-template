using System;
using System.Collections.Generic;
using System.Text;

namespace DbManager.Parser
{
    public class Delete : MiniSqlQuery
    {
        public string Table { get; private set; }
        public Condition Where { get; private set; }

        public Delete(string table, Condition where)
        {
            Table = table;
            Where = where;
        }

        public string Execute(Database database)
        {
            return null;
        }
    }
}
