using System;
using System.Linq;
using System.Net.Mail;
using System.Web.Mvc;
using System.Web.Security;
using MvcMembership;
using SampleWebsite.Models;
using SampleWebsite.Models.Administrar;

namespace SampleWebsite.Controllers
{
	//[Authorize(Roles="Administrator")]
	public class AdministrarController : Controller
	{
		private const int PageSize = 10;
		private const string ResetPasswordBody = "Sua nova senha é: ";
		private const string ResetPasswordFromAddress = "from@domain.com";
		private const string ResetPasswordSubject = "Nova Senha";
		private readonly IRolesService _rolesService;
		private readonly ISmtpClient _smtpClient;
		private readonly IUserService _userService;
		private readonly IPasswordService _passwordService;

		public AdministrarController()
			: this(
				new AspNetMembershipProviderWrapper(Membership.Provider),
				new AspNetMembershipProviderWrapper(Membership.Provider),
				new AspNetRoleProviderWrapper(Roles.Provider),
				new SmtpClientProxy(new SmtpClient()))
		{
		}

		public AdministrarController(
			IUserService userService,
			IPasswordService passwordService,
			IRolesService rolesService,
			ISmtpClient smtpClient)
		{
			_userService = userService;
			_passwordService = passwordService;
			_rolesService = rolesService;
			_smtpClient = smtpClient;
		}
        [Authorize(Roles = "Administrador")]
		public ViewResult Index(int? index)
		{
			return View(new IndexViewModel
			            	{
								Users = _userService.FindAll(index ?? 0, PageSize),
			            		Roles = _rolesService.FindAll()
			            	});
		}

		[AcceptVerbs(HttpVerbs.Post),Authorize(Roles = "Administrador")]
		public RedirectToRouteResult CreateRole(string id)
		{
			_rolesService.Create(id);
			return RedirectToAction("Index");
		}

		[AcceptVerbs(HttpVerbs.Post),Authorize(Roles = "Administrador")]
		public RedirectToRouteResult DeleteRole(string id)
		{
			_rolesService.Delete(id);
			return RedirectToAction("Index");
		}

        [Authorize(Roles = "Administrador")]
		public ViewResult Role(string id)
		{
			return View(new RoleViewModel
			            	{
			            		Role = id,
								Users = _rolesService.FindUserNamesByRole(id).Select(username => _userService.Get(username))
			            	});
		}

        [Authorize(Roles = "Administrador")]
		public ViewResult Details(Guid id)
		{
			var user = _userService.Get(id);
			var userRoles = _rolesService.FindByUser(user);
			return View(new DetailsViewModel
			            	{
			            		DisplayName = user.UserName,
			            		User = user,
			            		Roles = _rolesService.FindAll().ToDictionary(role=> role, role=> userRoles.Contains(role)),
			            		Status = user.IsOnline
			            		         	? DetailsViewModel.StatusEnum.Online
			            		         	: !user.IsApproved
			            		         	  	? DetailsViewModel.StatusEnum.Unapproved
			            		         	  	: user.IsLockedOut
			            		         	  	  	? DetailsViewModel.StatusEnum.LockedOut
			            		         	  	  	: DetailsViewModel.StatusEnum.Offline
			            	});
		}

		[AcceptVerbs(HttpVerbs.Post),Authorize(Roles = "Administrador")]
		public RedirectToRouteResult Details(Guid id,
		                            [Bind(Prefix = "User.Email")] string email,
		                            [Bind(Prefix = "User.Comment")] string comment)
		{
			var user = _userService.Get(id);
			user.Email = email;
			user.Comment = comment;
			_userService.Update(user);
			return RedirectToAction("Details", new {id});
		}

		[AcceptVerbs(HttpVerbs.Post),Authorize(Roles = "Administrador")]
		public RedirectToRouteResult DeleteUser(Guid id)
		{
			_userService.Delete(_userService.Get(id));
			return RedirectToAction("Index");
		}

		[AcceptVerbs(HttpVerbs.Post),Authorize(Roles = "Administrador")]
		public RedirectToRouteResult ChangeApproval(Guid id, bool isApproved)
		{
			var user = _userService.Get(id);
			user.IsApproved = isApproved;
			_userService.Update(user);
			return RedirectToAction("Details", new {id});
		}

		[AcceptVerbs(HttpVerbs.Post),Authorize(Roles = "Administrador")]
		public RedirectToRouteResult Unlock(Guid id)
		{
			_passwordService.Unlock(_userService.Get(id));
			return RedirectToAction("Details", new {id});
		}

		[AcceptVerbs(HttpVerbs.Post),Authorize]
		public RedirectToRouteResult ResetPassword(Guid id, string answer)
		{
			var user = _userService.Get(id);
			var newPassword = _passwordService.ResetPassword(user, answer);

			var body = ResetPasswordBody + newPassword;
			_smtpClient.Send(new MailMessage(ResetPasswordFromAddress, user.Email, ResetPasswordSubject, body));

			return RedirectToAction("Details", new {id});
		}

		[AcceptVerbs(HttpVerbs.Post),Authorize(Roles = "Administrador")]
		public RedirectToRouteResult AddToRole(Guid id, string role)
		{
			_rolesService.AddToRole(_userService.Get(id), role);
			return RedirectToAction("Details", new { id });
		}

		[AcceptVerbs(HttpVerbs.Post),Authorize(Roles = "Administrador")]
		public RedirectToRouteResult RemoveFromRole(Guid id, string role)
		{
			_rolesService.RemoveFromRole(_userService.Get(id), role);
			return RedirectToAction("Details", new { id });
		}
	}
}