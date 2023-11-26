using ese01.Models;
using ese01.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace ese01.Controllers
{

    // public class UsersController : Controller
    // {
    //     private readonly IUsersService _usersService;
    //     public UsersController(IUsersService userService)
    //     {
    //         _usersService = userService;
    //     }

    public class UsersController(IUsersService usersService) : Controller
    {
        private readonly IUsersService _usersService = usersService;

        public IActionResult Index()
        {
            return View(_usersService.GetAll());
        }

        public IActionResult UserDetail(int userId)
        {
            return View(_usersService.FindById(userId));
        }

        public IActionResult NewUser()
        {
            return View();
        }
        public IActionResult AddUser()
        {
            string name = Request.Form["Name"].ToString();
            string surname = Request.Form["Surname"].ToString(); ;
            DateTime dateOfBirth = Convert.ToDateTime(Request.Form["DateOfBirth"]);
            string placeOfBirth = Request.Form["PlaceOfBirth"].ToString(); ;

            UserModel newUser = new UserModel
            (
                -1,
                name,
                surname,
                dateOfBirth,
                placeOfBirth
            );
            _usersService.Add(newUser);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteUser(int id)
        {
            _usersService.DeleteById(id);
            return RedirectToAction("Index");
        }
    }
}