using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Data.Security;
using MvcMovie.Models;

namespace MvcMovie.Controllers;
public class LoginController : Controller
{
   private readonly MvcMovieContext _context;

    public LoginController(MvcMovieContext context)
    {
        _context = context;
    }

    // GET: Login/Index
    public IActionResult Index()
   {
      return View();
   }

   // POST: Login/Authenticate
   // To protect from overposting attacks, enable the specific properties you want to bind to.
   // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
   [HttpPost]
   [ValidateAntiForgeryToken]
   public async Task<IActionResult> Login([Bind("Email,Password")] Login user)
   {
      if (ModelState.IsValid)
      {
         user.Password = Utils.HashPassword(user.Password ?? "");
         var userInDb = await _context.User.FirstOrDefaultAsync(u => u.Email == user.Email && u.Password == user.Password);
         //if (userInDb.Email == user.Email)
         return RedirectToAction("Index", "Home");
      }
      return View(user);
   }
}
