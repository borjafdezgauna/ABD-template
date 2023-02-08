using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DbManager.Security
{
    public class Manager
    {
        public List<Profile> Profiles { get; private set; } = new List<Profile>();


        public Manager(string username)
        {
            
        }

        public bool IsUserAdmin()
        {
            
            return true;
        }

        public bool IsPasswordCorrect(string username, string password)
        {
            
            return true;
        }

        public void GrantPrivilege(string profileName, string table, Privilege privilege)
        {
            
        }

        public void RevokePrivilege(string profileName, string table, Privilege privilege)
        {
            
        }

        public bool IsGrantedPrivilege(string username, string table, Privilege privilege)
        {
            
            return true;
        }

        public void AddProfile(Profile profile)
        {
            
            return;
        }

        public User UserByName(string username)
        {
            
            return null;
        }

        public Profile ProfileByName(string profileName)
        {
            
            return null;
        }

        public Profile ProfileByUser(string username)
        {
            
            return null;
        }

        public bool RemoveProfile(string profileName)
        {
            
            return true;
        }

        public static Manager Load(string databaseName, string username)
        {
            
            return null;
        }

        public void Save(string databaseName)
        {
            
        }
    }
}
