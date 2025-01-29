using DbManager.Parser;
using DbManager.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManager
{
    public class Database
    {
        private List<Table> Tables = new List<Table>();
        private string m_username;

        public string LastErrorMessage { get; private set; }

        public Manager SecurityManager { get; private set; }

        //This constructor should only be used from Load (without needing to set a password for the user). It cannot be used from any other class
        private Database()
        {
        }

        public Database(string adminUsername, string adminPassword)
        {
            //DEADLINE 1.B: Initalize the member variables
            
        }

        public bool AddTable(Table table)
        {
            //DEADLINE 1.B: Add a new table to the database
            
            return false;
            
        }

        public Table TableByName(string tableName)
        {
            //DEADLINE 1.B: Find and return the table with the given name
            
            return null;
            
        }

        public bool CreateTable(string tableName, List<ColumnDefinition> ColumnDefinition)
        {
            //DEADLINE 1.B: Create and new table with the given name and columns. If there is already a table with that name,
            //return false and set LastErrorMessage with the appropriate error (Check Constants.cs)
            //Do the same if no column is provided
            //If everything goes ok, set LastErrorMessage with the appropriate success message (Check Constants.cs)
            
            return false;
            
        }

        public bool DropTable(string tableName)
        {
            //DEADLINE 1.B: Delete the table with the given name. If there is none, return false and set LastErrorMessage
            //If everything goes ok, return true and set LastErrorMessage with the appropriate success message (Check Constants.cs)
            
            return false;
        }

        public bool Insert(string tableName, List<string> values)
        {
            //DEADLINE 1.B: Insert a new row to the table. If it doesn't exist return false and set LastErrorMessage appropriately (Check Constants.cs)
            //If everything goes ok, set LastErrorMessage with the appropriate success message (Check Constants.cs)
            
            return false;
            
        }

        public Table Select(string tableName, List<string> columns, Condition condition)
        {
            //DEADLINE 1.B: Return the result of the select. If the table doesn't exist return null and set LastErrorMessage appropriately (Check Constants.cs)
            //If any of the requested columns doesn't exist, return null and set LastErrorMessage (Check Constants.cs)
            //If everything goes ok, return the table
            
            return null;
            
        }

        public bool DeleteWhere(string tableName, Condition columnCondition)
        {
            //DEADLINE 1.B: Delete all the rows where the condition is true. 
            //If the table or the column in the condition don't exist, return null and set LastErrorMessage (Check Constants.cs)
            //If everything goes ok, return true
            
            return false;
            
        }

        public bool Update(string tableName, List<SetValue> columnNames, Condition columnCondition)
        {
            //DEADLINE 1.B: Update in the given table all the rows where the condition is true using the SetValues
            //If the table or the column in the condition don't exist, return null and set LastErrorMessage (Check Constants.cs)
            //If everything goes ok, return true
            
            return false;
            
        }

        
        

        private const string TableFileExtension = ".tbl";
        public bool Save(string databaseName)
        {
            //DEADLINE 1.C: Save this database to disk with the given name
            //If everything goes ok, return true, false otherwise.
            
            return false;
            
        }

        public static Database Load(string databaseName, string username, string password)
        {
            //DEADLINE 1.C: Load the (previously saved) database of name databaseName
            //If everything goes ok, return the loaded database (a new instance), null otherwise.
            
            return null;
        }

        public string ExecuteMiniSQLQuery(string query)
        {
            //Parse the query
            MiniSqlQuery miniSQLQuery = MiniSQLParser.Parse(query);

            //If the parser returns null, there must be a syntax error (or the parser is failing)
            if (miniSQLQuery == null)
                return Constants.SyntaxError;

            //Once the query is parsed, we run it on this database
            return miniSQLQuery.Execute(this);
        }


        public bool IsUserAdmin()
        {
            return SecurityManager.IsUserAdmin();
        }





        //From here on, ONLY FOR TESTING
        public const string AdminUsername = "admin";
        public const string AdminPassword = "adminPassword";
        public static Database CreateTestDatabase()
        {
            Database database = new Database(AdminUsername, AdminPassword);

            database.Tables.Add(Table.CreateTestTable());

            return database;
        }

        public void AddTuplesForTesting(string tableName, List<List<string>> rows)
        {
            Table table = TableByName(tableName);
            foreach (List<string> row in rows)
            {
                table.Insert(row);
            }
        }

        public void CheckForTesting(string tableName, List<List<string>> rows)
        {
            Table table = TableByName(tableName);

            table.CheckForTesting(rows);
        }
    }
}





