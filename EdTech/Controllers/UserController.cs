using EdTech.Assests;
using EdTech.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.SqlServer.Server;

namespace EdTech.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context ; 
        public UserController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Register()
        {
            List<string> items = new List<string>();
            items.Add("Teacher");
            items.Add("Student");
            var userTypes = new SelectList(items, "Student");
            ViewData["UserTypes"] = userTypes;
            return View();
        }
        [HttpPost]
        public IActionResult Register(Users formData)
        {

            try
            {
                
                if(formData == null) return View();

                if(string.IsNullOrEmpty(formData.Email)) return View();

                var existingUser = _context.Users.Where(x=>x.Email == formData.Email).FirstOrDefault();
                if(existingUser != null)
                {
                    TempData["ErrorMsg"] = "Email Aleready exists";
                    return View();
                } 

                Users newUser = new Users();
                newUser.FullName = formData.FullName;
                newUser.Email = formData.Email;
                newUser.Password = formData.Password;
                newUser.UserType = formData.UserType;
                newUser.Status = "Active";
                newUser.CreatedAt = DateTime.Now;
                newUser.ModifiedAt = DateTime.Now;
                newUser.isDeleted = false;


                _context.Users.Add(newUser);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {

            }

            
            return Redirect("/Courses/");

        }
        
        
        
        
        
        
        
        //User/Login?

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Users usersFormData)
        {
            if (usersFormData == null) return View();

            if (string.IsNullOrEmpty(usersFormData.Email)) return View();
            var existingUser = _context.Users.Where(x => x.Email == usersFormData.Email).FirstOrDefault();
            if (existingUser == null)
            {
                TempData["ErrorMsgLogin"] = "Email Do Not Exists";
                return View();
            }
            return View();
        }
    }
}
