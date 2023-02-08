using DbManager.Parser;
using System;
using System.Collections.Generic;

namespace DbManager
{
    public class Table
    {
        //TODO
        public List<Column> Columns = new List<Column>();
        public string Name = null;

        public Table(string name, List<Column> columns)
        {
            Name = name;
            Columns = columns;
        }

        public bool Load(string path)
        {
            return false;
        }

        public bool Save(string databaseName)
        {
            return false;
        }
        
        public Column ColumnByName(string column)
        {
            return null;
        }
        public void DeleteColumnByName(string name)
        {
            
        }


        public override string ToString()
        {
            
            return null;
        }

        public void DeleteWhere(Condition condition)
        {
            
        }

        public bool Insert(List<string> values)
        {
            
            return false;
        }

        public bool Update(List<SetValue> setValues, Condition condition, out string errorMessage)
        {
            errorMessage = null;
            return false;
        }
    }
}