using StudentsCoursCesi.Services.StudentsService;
using StudentsCoursCesi.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


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
		[Authorize]
		public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
		[Authorize]
		public async Task<IActionResult> Add(Students students)
        {
            Students newStudent = new Students
            {
                Email = students.Email,
                UserName = students.UserName,
                FirstName = students.FirstName,
                LastName = students.LastName
            };

            await _studentsService.AddStudentsAsync(newStudent);
            return RedirectToAction(nameof(List));

        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            var student = await _studentsService.GetStudentsByIdAsync(id);
            return View(student);
        }
        [HttpPost]
		public async Task<IActionResult> Edit(Students students)
        {
            await _studentsService.UpdateStudentsAsync(students);
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
		[Authorize]
		public async Task<IActionResult> Delete(int id)
        {
            var student = await _studentsService.GetStudentsByIdAsync(id);
            return View(student);
        }
        [HttpPost]
		[Authorize]
		public async Task<IActionResult> Delete(Students students)
        {
            await _studentsService.DeleteStudentsAsync(students);
            return RedirectToAction(nameof(List));
        }
    }
}
