//using DiPatternDemo.Models;
//using DiPatternDemo.Services;
//using Microsoft.AspNetCore.Mvc;

//namespace DiPatternDemo.Controllers
//{
    
//    public class UserController : Controller
//    {
//    private readonly IUserService service;
//        public UserController(IUserService service)
//        {
//            this.service = service;
//        }
//        [HttpGet]
//        public IActionResult Login()
//        {
//            return View();
//        }
//        [HttpPost]
//        public IActionResult Login(User user)
//        {
            
//            return View(ValidateUser(user));
//        }

//        [HttpGet]
//        public IActionResult Register()
//        {
//            return View();
//        }
//        [HttpPost]
//        public IActionResult Register(User user)
//        {
//            AddUser(user);
//        }

//    }
//}
