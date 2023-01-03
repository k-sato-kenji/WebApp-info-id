using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace WebApp.Models
{
    public class CustomRoleProvider : RoleProvider
    {
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        //  修正追加実装											
        public override string[] GetRolesForUser(string username)
        {
            // 固定で設定する											
            if ("admin".Equals(username))
            {
                return new string[] { "Admin" };
            }

            return new string[] { "Users" };

        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        //  修正追加実装											
        public override bool IsUserInRole(string username, string roleName)
        {
            // 固定で設定する											
            if ("admin".Equals(username) && "Admin".Equals(roleName))
            {
                return true;
            }

            if ("user".Equals(username) && "User".Equals(roleName))
            {
                return true;
            }
            return false;

        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}