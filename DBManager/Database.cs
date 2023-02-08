using DbManager.Parser;
using DbManager.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManager
{
    public class Database
    {
        public List<Table> Tables { get; private set; } = new List<Table>();
        public string Name = null;
        private string m_username;

        public string LastErrorMessage { get; private set; }

        public Security.Manager SecurityManager { get; private set; }

        //This constructor is only used from Load (without needing to set a password for the user). It cannot be used from any other class
        private Database()
        {
        }

        public Database(string adminUsername, string adminPassword)
        {
            
        }


        public static Database Load(string databaseName, string username, string password)
        {
            return null;
        }



        public bool Save(string databaseName)
        {
            return false;
        }
        private const string DefaultResultTableName = "Result";
        public Table Select(string table, List<string> columns, Condition columnCondition)
        {
            return null;
        }

        public bool DeleteWhere(string tableName, Condition columnCondition)
        {
            return false;
        }

        public bool Update(string tableName, List<SetValue> columnNames, Parser.Condition columnCondition)
        {
            return false;
        }

        public bool Insert(string tableName, List<string> values)
        {
            return false;
        }

        public string ExecuteMiniSQLQuery(string query)
        {
            //Parse the query
            MiniSqlQuery miniSQLQuery = MiniSQLParser.Parse(query);

            if (miniSQLQuery == null)
                return Constants.SyntaxError;

            return miniSQLQuery.Execute(this);
        }

        public Table TableByName(string tableName)
        {
            return null;
        }
        public bool DropTable(string tableName)
        {
            
            return false;
        }
        public void AddTable(Table table)
        {
            
        }

        public bool CreateTable(string tableName, List<ColumnParameters> columnParameters)
        {
            return false;
        }

        public bool IsUserAdmin()
        {
            return true;
        }
    }
}





