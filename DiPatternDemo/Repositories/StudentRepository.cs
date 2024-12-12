using DiPatternDemo.Data;
using DiPatternDemo.Models;

namespace DiPatternDemo.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext db;
        public StudentRepository(ApplicationDbContext db)
        {
            this.db = db;   
        }
        public int AddStudent(Student student)
        {
            int result = 0;
            db.Students.Add(student);
            result=db.SaveChanges();
            return result;
        }

        public int DeleteStudent(int id)
        {
            int result = 0;
            var stud = db.Students?.Where(x => x.StuId == id).SingleOrDefault();
            if(stud != null)
            {
                db.Students?.Remove(stud);
                result = db.SaveChanges();
            }
            return result;
        }

        public Student GetStudentById(int id)
        {
            return db.Students?.Where(x => x.StuId == id).SingleOrDefault();
        }

        public IEnumerable<Student> GetStudents()
        {
            return db.Students.ToList();
        }

        public int UpdateStudent(Student student)
        {
            int result = 0;
            var stud=db.Students?.Where(x=>x.StuId==student.StuId).SingleOrDefault();
            if( stud != null)
            {
                stud.Name= student.Name;
                stud.Branch= student.Branch;
                stud.Marks= student.Marks;
                result = db.SaveChanges();
            }
            return result;
        }
    }
}
