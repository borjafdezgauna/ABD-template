using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using DbManager;

namespace DbManager.Parser
{
    public class Condition
    {
        public string Column { get; private set; }
        public string Operator { get; private set; }
        public string LiteralValue { get; private set; }

        public Condition(string column, string op, string literalValue)
        {
            Column = column;
            Operator = op;
            LiteralValue = literalValue;
        }

       

        public bool ValueMeetsCondition(string value, Column.DataType type)
        {
            return false;
        }
    }
}