using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSystem.Core.Entities;

namespace StudentSystem.Infrastructure.Data
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> Get(int id);
        Task<Student> Add(Student student);
        Task<Student> Update(Student student);
        Task Delete(int id);
    }
}
