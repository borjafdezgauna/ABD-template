﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManager
{
    public class Constants
    {
        public const string Error = "ERROR: ";
        public const string CreateTableSuccess = "Table created";
        public const string InsertSuccess = "Tuple added";
        public const string DeleteSuccess = "Tuple(s) deleted";
        public const string UpdateSuccess = "Tuple(s) updated";
        public const string DropTableSuccess = "Table dropped";
        public const string SyntaxError = Error + "Syntactical error";
        public const string DatabaseDoesNotExistError = Error + "Database does not exist";
        public const string DatabaseCreatedWithoutColumnsError = Error + "Cannot create table without columns";
        public const string TableDoesNotExistError = Error + "Table does not exist";
        public const string TableAlreadyExistsError = Error + "Table exists already";
        public const string ColumnDoesNotExistError = Error + "Column does not exist";

        public const string CreateSecurityProfileSuccess = "Security profile created";
        public const string DropSecurityProfileSuccess = "Security profile dropped";
        public const string GrantPrivilegeSuccess = "Security privilege granted";
        public const string RevokePrivilegeSuccess = "Security privilege revoked";
        public const string AddUserSuccess = "User added";
        public const string DeleteUserSuccess = "User deleted";
        public const string SecurityProfileDoesNotExistError = Error + "Security profile does not exist";
        public const string UserDoesNotExistError = Error + "Security profile does not exist";
        public const string UserDoesNotHavePrivilegeError = Error + "Privilege cannot be revoked because the profile has not been granted it";
        public const string PrivilegeDoesNotExistError = Error + "Privilege does not exist";
        public const string ProfileAlreadyHasPrivilege = Error + "Profile already has privilege";
        public const string UsersProfileIsNotGrantedRequiredPrivilege = Error + "The security profile of the user does not have the required privilege to perform the operation";
    }
}
