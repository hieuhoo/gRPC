using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gRPCqlsinhvien.Models
{
    public class Teacher
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }

        public virtual DateTime Ngaysinh { get; set; }
        public virtual ICollection<Class> Lophoc {  get; set; }
    }
}
