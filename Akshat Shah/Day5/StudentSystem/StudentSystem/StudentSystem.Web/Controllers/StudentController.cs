using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentSystem.Core.Entities;
using StudentSystem.Infrastructure.Data;
using StudentViewModel = StudentSystem.Web.Models.Student;
using StudentRecords = StudentSystem.Web.Models.StudentRecords;


namespace StudentSystem.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _repository;

        public StudentController(IStudentRepository repository)
        {
            _repository = repository;
        }

        // GET: StudentController
        public async Task<ActionResult> Index()
        {
            IEnumerable<Student> students = await _repository.GetAll();
            List<StudentViewModel> studentViewModels = new List<StudentViewModel>();
            foreach (Student student in students)
            {
                studentViewModels.Add(new StudentViewModel
                {
                    Id = student.Id,
                    Name = student.Name,
                    Gpa = student.Gpa,
                    EmailAddress = student.EmailAddress
                });
            }
            return View(new StudentRecords { Students = studentViewModels });
        }

        // GET: StudentController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            Student student = await _repository.Get(id);
            if (student == null)
            {
                return NotFound();
            }
            StudentViewModel studentViewModel = new StudentViewModel
            {
                Id = student.Id,
                Name = student.Name,
                EmailAddress = student.EmailAddress,
                Gpa = student.Gpa
            };
            return View(studentViewModel);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                // TODO: Add create logic
                await _repository.Add(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
