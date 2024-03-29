﻿using System.Collections.Generic;
using System.Web.Security;

namespace MvcMembership
{
	public interface IRolesService
	{
		IEnumerable<string> FindAll();
		IEnumerable<string> FindByUser(MembershipUser user);
		IEnumerable<string> FindByUserName(string userName);
		IEnumerable<string> FindUserNamesByRole(string roleName);
		void AddToRole(MembershipUser user, string roleName);
		void RemoveFromRole(MembershipUser user, string roleName);
		bool IsInRole(MembershipUser user, string roleName);
		void Create(string roleName);
		void Delete(string roleName);
	}
}