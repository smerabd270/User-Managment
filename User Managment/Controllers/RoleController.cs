using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using User_Managment.ViewModels;

namespace User_Managment.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var role = await _roleManager.Roles.ToListAsync();
            return View(role);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(RoleFormViewModel model)
        {
            if (!ModelState.IsValid)
                return View("Index", await _roleManager.Roles.ToListAsync());
            if (await _roleManager.RoleExistsAsync(model.Name))
            {
                ModelState.AddModelError("Name", "Role is exists !");
                return View("Index", await _roleManager.Roles.ToListAsync());
            }
            await _roleManager.CreateAsync(new IdentityRole (model.Name.Trim()));
            return RedirectToAction(nameof(Index));

        }
    }
}
