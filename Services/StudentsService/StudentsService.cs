using Microsoft.EntityFrameworkCore;
using StudentsCoursCesi.Data;
using StudentsCoursCesi.Models.Entities;

namespace StudentsCoursCesi.Services.StudentsService
{
    public class StudentsService : IStudentsService
    {
        private readonly StudentsContext _context;

        public StudentsService(StudentsContext context)
        {
            _context = context;
        }
        public async Task<Students> AddStudentsAsync(Students Students)
        {
            _context.Students.Add(Students);
            await _context.SaveChangesAsync();
            return Students;
        }

        public async Task<Students> DeleteStudentsAsync(Students Students)
        {
            _context.Students.Remove(Students);
            await _context.SaveChangesAsync();
            return Students;
        }

        public async Task<IEnumerable<Students>> GetAllStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Students> GetStudentsByIdAsync(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        public async Task<Students> UpdateStudentsAsync(Students Students)
        {
            _context.Entry(Students).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Students;
        }
    }
}

