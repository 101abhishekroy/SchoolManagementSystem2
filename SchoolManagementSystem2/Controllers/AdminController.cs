using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem2.Areas.Identity.Data;


public class AdminController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;

    public AdminController(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    [Authorize(Roles = "Admin")]
    public IActionResult Dashboard()
    {
        return View();
    }

    [Authorize(Roles = "Admin")]
    public IActionResult Users()
    {
        return View(_userManager.Users.ToList());
    }

    [HttpPost]
    public async Task<IActionResult> MakeTeacher(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user != null)
        {
            await _userManager.AddToRoleAsync(user, "Teacher");
        }
        return RedirectToAction("Users");
    }

    [HttpPost]
    public async Task<IActionResult> MakeStudent(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user != null)
        {
            await _userManager.AddToRoleAsync(user, "Student");
        }
        return RedirectToAction("Users");
    }
}
