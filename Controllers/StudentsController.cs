using StudentsCoursCesi.Services.StudentsService;
using StudentsCoursCesi.Models.Entities;
using Microsoft.AspNetCore.Mvc;


namespace StudentsCoursCesi.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentsService _studentsService;

        public StudentsController(IStudentsService studentsService)
        {
            _studentsService = studentsService;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var students = await _studentsService.GetAllStudentsAsync();
            return View(students);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Students students)
        {
            students = await _studentsService.AddStudentsAsync(students);
            return RedirectToAction(nameof(List));

        }

    }
}
