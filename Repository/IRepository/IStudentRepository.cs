using gRPCqlsinhvien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace gRPCqlsinhvien.Repository.IRepository
{
    interface IStudentRepository
    {
        public List<Student> GetSinhviens();
        public void Addnewstudent(Student student);
        public void Updatenewstudent(Student studentUpdate);
        public void Deletestudent(Student student);
        public List<Student> Sortbyname();
        public void Findstudentbyname();

    }
}
