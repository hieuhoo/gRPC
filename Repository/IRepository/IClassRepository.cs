using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gRPCqlsinhvien;
using gRPCqlsinhvien.Models;

namespace gRPCqlsinhvien.Repository.IRepository
{
    interface IClassRepository
    {
        public List<Class> GetAllClass();
        public Class GetClassById(int id);
        public Boolean Delete(Class _class);
        public Boolean Add(Class _class);
        public int GetNewClassID();  //phương thức
    }
}
