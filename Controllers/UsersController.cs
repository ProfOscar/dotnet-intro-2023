using ese01.Models;
using Microsoft.AspNetCore.Mvc;

namespace ese01.Controllers
{
    public class UsersController : Controller
    {
        private List<UserModel> users = new List<UserModel>
            {
                new UserModel(1,"Paolino","Paperino", new DateTime(1934,5,29), "San Francisco"),
                new UserModel(2,"Giuseppe","Garibaldi", new DateTime(1790,10,5), "Nizza"),
            };

        public IActionResult Index()
        {
            return View(users);
        }

        public IActionResult Detail(string id)
        {
            return Content($"Sono Detail e l'id che ho ricevuto è {id}");
        }
    }
}