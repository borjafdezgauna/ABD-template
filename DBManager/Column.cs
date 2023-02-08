using DbManager.Parser;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbManager
{
    public class Column
    {
        public enum DataType { String, Int, Double}

        public DataType Type;
        public string Name { get; private set; }
        public List<string> Values { get; set; } = new List<string>();
        public Column(DataType type, string name, List<string> values)
        {
            Type = type;
            Name = name;
            Values = values;
        }

        public Column(DataType type, string name)
        {
            Type = type;
            Name = name;
        }

        public List<int> IndicesWhereIsTrue(Condition condition)
        {
            List<int> indexes = new List<int>();
            
            //TODO

            return indexes;
        }

        

        public void UpdateWhere(Condition condition, string value)
        {
            
        }

        public void SetValue(int pos,string value)
        {
            
        }
        public void DeleteAt(int pos)
        {
            
        }

        public bool Save(string directory)
        {
            return false;
        }

        public static Column Load(string file)
        {
            return null;
        }
    }
}
