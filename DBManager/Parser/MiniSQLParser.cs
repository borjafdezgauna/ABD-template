using DbManager.Parser;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DbManager
{
    public class MiniSQLParser
    {
        public static MiniSqlQuery Parse(string miniSQLQuery)
        {
            const string createSecurityProfilePattern = "CREATE\\s+SECURITY\\s+PROFILE\\s+(\\w+)";
            const string dropSecurityProfilePattern = "DROP\\s+SECURITY\\s+PROFILE\\s+(\\w+)";
            const string grantPattern = "GRANT\\s+(DELETE|INSERT|SELECT|UPDATE)\\s+ON\\s+(\\w+)\\s+TO\\s+(\\w+)";
            const string revokePattern = "REVOKE\\s+(DELETE|INSERT|SELECT|UPDATE)\\s+ON\\s+(\\w+)\\s+TO\\s+(\\w+)";
            const string addUserPattern = "ADD\\s+USER\\s+\\(([^\\)]+)\\)";
            const string deleteUserPattern = "DELETE\\s+USER\\s+(\\w+)";

            Match match;

            //REGULAR MINISQL QUERIES





            //SECURITY QUERIES

            //CreateSecurityProfile
            match = Regex.Match(miniSQLQuery, createSecurityProfilePattern);
            if (match.Success && match.Length == miniSQLQuery.Length)
            {
                //Check the profile is only letters and numbers
                Match match2 = Regex.Match(match.Groups[1].Value, "[a-zA-Z]+");
                if (!match2.Success || match2.Length != match.Groups[1].Value.Length)
                    return null;
                return new CreateSecurityProfile(match.Groups[1].Value);
            }
            //DropSecurityProfile
            match = Regex.Match(miniSQLQuery, dropSecurityProfilePattern);
            if (match.Success && match.Length == miniSQLQuery.Length)
            {
                //Check the profile is only letters and numbers
                Match match2 = Regex.Match(match.Groups[1].Value, "[a-zA-Z]+");
                if (!match2.Success || match2.Length != match.Groups[1].Value.Length)
                    return null;
                return new DropSecurityProfile(match.Groups[1].Value);
            }
            //Grant
            match = Regex.Match(miniSQLQuery, grantPattern);
            if (match.Success && match.Length == miniSQLQuery.Length)
            {
                string parameters = match.Groups[1].Value;

                //Check the user is only letters and numbers
                Match match2 = Regex.Match(match.Groups[1].Value, "[a-zA-Z]+");
                if (!match2.Success || match2.Length != match.Groups[1].Value.Length)
                    return null;
                //Check the profile is only letters and numbers
                match2 = Regex.Match(match.Groups[3].Value, "[a-zA-Z]+");
                if (!match2.Success || match2.Length != match.Groups[3].Value.Length)
                    return null;
                return new Grant(match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value);
            }
            //Revoke
            match = Regex.Match(miniSQLQuery, revokePattern);
            if (match.Success && match.Length == miniSQLQuery.Length)
            {
                //Check the user is only letters and numbers
                Match match2 = Regex.Match(match.Groups[1].Value, "[a-zA-Z]+");
                if (!match2.Success || match2.Length != match.Groups[1].Value.Length)
                    return null;
                //Check the profile is only letters and numbers
                match2 = Regex.Match(match.Groups[3].Value, "[a-zA-Z]+");
                if (!match2.Success || match2.Length != match.Groups[3].Value.Length)
                    return null;
                return new Revoke(match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value);
            }
            //AddUser
            match = Regex.Match(miniSQLQuery, addUserPattern);
            if (match.Success && match.Length == miniSQLQuery.Length)
            {
                string parameters = match.Groups[1].Value;
                List<string> splitParameters = CommaSeparatedNames(parameters);
                if (splitParameters.Count == 3)
                {
                    //Check the user is only letters and numbers
                    Match match2 = Regex.Match(splitParameters[0], "[a-zA-Z]+");
                    if (!match2.Success || match2.Length != splitParameters[0].Length)
                        return null;
                    //Check the profile is only letters and numbers
                    match2 = Regex.Match(splitParameters[2], "[a-zA-Z]+");
                    if (!match2.Success || match2.Length != splitParameters[2].Length)
                        return null;
                    return new AddUser(splitParameters[0], splitParameters[1], splitParameters[2]);
                }
            }
            //RemoveUser
            match = Regex.Match(miniSQLQuery, deleteUserPattern);
            if (match.Success && match.Length == miniSQLQuery.Length)
            {
                //Check the user is only letters and numbers
                Match match2 = Regex.Match(match.Groups[1].Value, "[a-zA-Z]+");
                if (!match2.Success || match2.Length != match.Groups[1].Value.Length)
                    return null;
                return new DeleteUser(match.Groups[1].Value);
            }
            return null;
        }

        /// <summary>
        /// This method returns the elements in a string split by commas. For example, if text="el1,el2,el3",
        /// CommaSepatartedNames(text) => {"el1","el2","el3"}
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static List<string> CommaSeparatedNames(string text)
        {
            string[] textParts = text.Split(",", System.StringSplitOptions.RemoveEmptyEntries);
            List<string> commaSeparator = new List<string>();
            for(int i=0; i < textParts.Length; i++)
            {
                commaSeparator.Add(textParts[i]);
            }
            return commaSeparator;
        }
        
    }
}
