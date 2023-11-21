//using EdTech.Assests;
//using EdTech.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace EdTech.Controllers
//{
//    public class SubjectsController : Controller
//    {
//        private readonly AppDbContext _context; 
//        public SubjectsController(AppDbContext context)
//        {
//            _context = context;
//        }
//        public IActionResult Index()
//        {
//            var data = _context.Subjects.ToList();
//            return View(data);
//        }
//        public IActionResult addSubject()
//        {

//            return View();

//        }
//        [HttpPost]
//        public IActionResult addSubject(Subjects formData)
//        {
//            if (!ModelState.IsValid)
//            {
//                return View(formData);
//            }

//            _context.Subjects.Add(formData);
//            _context.SaveChanges();
//            return RedirectToAction(nameof(Index));
//        }
//        public IActionResult deleteSubject(int id)
//        {
//            var subjectDetails = _context.Subjects.FirstOrDefault(x => x.SubjectId == id);
//            return View(subjectDetails);
//        }
//        [HttpPost, ActionName("deleteSubject")]
//        public IActionResult deleteSubjectById(int id)
//        {
//            var deleteSubject = _context.Subjects.FirstOrDefault(x => x.SubjectId == id);
//            _context.Courses.Remove(deleteSubject);
//            _context.SaveChanges();
//            return RedirectToAction(nameof(Index));
//        }
//    }
//}
