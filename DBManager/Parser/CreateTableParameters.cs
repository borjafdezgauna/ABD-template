using System;
using System.Collections.Generic;
using System.Text;

namespace DbManager.Parser
{
    public class ColumnParameters
    {
        public string Name { get; private set; }
        public Column.DataType Type { get; private set; }

        public ColumnParameters(string column, Column.DataType type)
        {
            Name = column;
            Type = type;
        }
    }
}
