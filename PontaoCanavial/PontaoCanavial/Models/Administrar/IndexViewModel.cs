using System.Collections.Generic;
using System.Web.Security;
using PagedList;

namespace SampleWebsite.Models.Administrar
{
	public class IndexViewModel
	{
		public IPagedList<MembershipUser> Users { get; set; }
		public IEnumerable<string> Roles { get; set; }
	}
}