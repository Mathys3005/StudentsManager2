using StudentsCoursCesi.Models.Entities;

namespace StudentsCoursCesi.Services.StudentsService
{
    public interface IStudentsService
    {
        Task<IEnumerable<Students>> GetAllStudentsAsync();
        Task<Students> GetStudentsByIdAsync(int id);
        Task<Students> AddStudentsAsync(Students Students);
        Task<Students> UpdateStudentsAsync(Students Students);
        Task<Students> DeleteStudentsAsync(Students Students);
    }
}
