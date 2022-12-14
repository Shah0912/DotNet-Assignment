using Microsoft.EntityFrameworkCore;
using StudentSystem.Core.Entities;

namespace StudentSystem.Infrastructure.Data
{
    public class StudentRepository : IStudentRepository
    {

        private StudentDbContext _context;

        public StudentRepository(StudentDbContext context)
        {
            _context = context;
        }

        public async Task<Student> Add(Student student)
        {
            student = (await _context.Students.AddAsync(student)).Entity;
            await _context.SaveChangesAsync();
            return student;
        }

        public async Task Delete(int id)
        {
            Student student = await _context.Students.FindAsync(id);
            if (student == null)
                return;
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
        }

        public async Task<Student> Get(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> Update(Student student)
        {
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
            return student;
        }
    }
}
