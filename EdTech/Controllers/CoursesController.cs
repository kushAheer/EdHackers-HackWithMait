using EdTech.Assests;
using EdTech.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.SqlServer.Server;

namespace EdTech.Controllers
{
    public class CoursesController : Controller
    {
        private readonly AppDbContext _context;
        public CoursesController(AppDbContext context)
        {
            _context = context;
        }


        //Courses/
        public IActionResult Index()
        {
            var data = _context.Courses.ToList();
            return View(data);
        }
        //Courses/addCourse
        public IActionResult addCourse()
        {
    
            return View();

        }
        [HttpPost]
        public IActionResult addCourse(Courses formData)
        {

            Courses course = new Courses();
            course.isDeleted = false;
            course.CreatedAt = DateTime.Now;
            course.ModifiedAt = DateTime.Now;
            course.CourseOrder = formData.CourseId;
            course.CourseImage = formData.CourseImage;
            course.CourseDesc = formData.CourseDesc;
            course.CourseName = formData.CourseName;
            course.AuthorId = 1;
            course.SubjectName = formData.SubjectName;
            
            //if (!ModelState.IsValid)
            //{
            //    return View(formData);
            //}
           
            _context.Courses.Add(course);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult editCourse(int id)
        {
            var courseDetails = _context.Courses.FirstOrDefault(x => x.CourseId == id);
            return View(courseDetails);
        }
        [HttpPost]
        public IActionResult editCourse(Courses editCourseData)
        {
            Courses course = new Courses();
            course.isDeleted = false;
            course.CreatedAt = editCourseData.CreatedAt;
            course.ModifiedAt = DateTime.Now;
            course.CourseOrder = editCourseData.CourseId;
            course.CourseImage = editCourseData.CourseImage;
            course.CourseDesc = editCourseData.CourseDesc;
            course.CourseName = editCourseData.CourseName;
            course.AuthorId = 1;
            course.SubjectName = editCourseData.SubjectName;

            _context.Courses.Update(course);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult deleteCourse(int id)
        {
            var courseDetails = _context.Courses.FirstOrDefault(x => x.CourseId == id);
            return View(courseDetails);
        }
        [HttpPost,ActionName("deleteCourse")]
        public IActionResult deleteCourseById(int id)
        {
            var deleteData = _context.Courses.FirstOrDefault(x => x.CourseId == id);
            _context.Courses.Remove(deleteData);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
