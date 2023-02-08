using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DbManager.Parser
{
    public class SetValue
    {
        public string Column = null;
        public string Value = null;


        public SetValue(string column, string value)
        {
            Column = column;
            Value = value;
        }
    }
}
