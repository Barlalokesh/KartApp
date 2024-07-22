using KartApp.DAL;
using KartApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace KartApp.Controllers
{
    public class RoleController : Controller
    {
        private readonly KartDbContext _kartDbContext;
        public RoleController(KartDbContext kartDbContext)
        {
            _kartDbContext = kartDbContext;
        }
        public IActionResult Index()
        {
            Role r = new Role();
            RoleRepo role=new RoleRepo(_kartDbContext);
            var data=role.getRoles();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Role role)
        {
            RoleRepo roleRepo = new RoleRepo(_kartDbContext);
            var data=roleRepo.AddRoles(role);
            return RedirectToAction("Index");

        }

    }
}
