using System.Collections.Generic;
using System.Web.Security;

namespace SampleWebsite.Models.Administrar
{
	public class RoleViewModel
	{
		public string Role { get; set; }
		public IEnumerable<MembershipUser> Users { get; set; }
	}
}