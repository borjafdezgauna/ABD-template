using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManager.Parser
{
    public static class DataTypeUtils
    {
        public static Column.DataType FromMiniSQLName(string typeName)
        {
            if (typeName == "INT")
                return Column.DataType.Int;
            else if (typeName == "DOUBLE")
                return Column.DataType.Double;
            else if (typeName == "TEXT")
                return Column.DataType.String;
            throw new Exception($"Unknown MiniSQL data type: {typeName}");
        }

        public static Column.DataType FromMiniTypeName(string typeName)
        {
            if (typeName == "Int")
                return Column.DataType.Int;
            else if (typeName == "Double")
                return Column.DataType.Double;
            else if (typeName == "String")
                return Column.DataType.String;
            throw new Exception($"Unknown MiniSQL data type: {typeName}");
        }
    }
}
