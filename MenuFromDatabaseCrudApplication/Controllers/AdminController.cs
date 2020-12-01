using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuFromDatabaseCrudApplication.Models;
using MenuFromDatabaseCrudApplication.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MenuFromDatabaseCrudApplication.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ProductContext _context;

        public AdminController(RoleManager<IdentityRole> roleManager,UserManager<ApplicationUser> userManager,ProductContext context)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _context = context;
        }

        public ActionResult AssignRole()
        {
            ViewData["Users"] = new SelectList(_context.Users, "Id", "UserName");
            ViewData["Roles"] = new SelectList(_context.Roles, "Name", "Name");

            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AssignRole(UserRoleVM uvm)
        {
            string msg = string.Empty;
            if (ModelState.IsValid)
            {
                var user= await _userManager.FindByIdAsync(uvm.UserId);
                IList<string> roles = await _userManager.GetRolesAsync(user);
                if (roles.Contains(uvm.Role))
                {
                    ModelState.AddModelError("", "Already assigned");
                }
                else
                {
                    await _userManager.AddToRoleAsync(user, uvm.Role);
                }
                
            }
            ViewData["Users"] = new SelectList(_context.Users, "Id", "UserName",uvm.UserId);
            ViewData["Roles"] = new SelectList(_context.Roles, "Name", "Name",uvm.Role);
            return View(uvm);
        }

    }
}
