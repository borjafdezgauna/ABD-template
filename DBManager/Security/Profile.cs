using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManager.Security
{
    public class Profile
    {
        public const string AdminProfileName = "Admin";
        public string Name { get; set; }
        public List<User> Users { get; set; } = new List<User>();

        public Dictionary<string, List<Privilege>> PrivilegesOn { get; private set; } = new Dictionary<string, List<Privilege>>();

        public bool GrantPrivilege(string table, Privilege privilege)
        {
            return false;
        }

        public bool RevokePrivilege(string table, Privilege privilege)
        {
            return false;
        }

        public bool IsGrantedPrivilege(string table, Privilege privilege)
        {
            return false;
        }
    }
}
