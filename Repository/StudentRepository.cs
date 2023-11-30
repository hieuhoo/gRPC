using FluentNHibernate.Visitors;
using NHibernate;
using NHibernate.Linq;
using gRPCqlsinhvien;


using Grpc;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gRPCqlsinhvien.Repository.IRepository;
using gRPCqlsinhvien.Models;

namespace gRPCqlsinhvien
{
    class StudentRepository : IStudentRepository
    {
        private readonly IClassRepository _classRepository;
        private readonly ISessionFactory _session;
        public StudentRepository(IClassRepository classRepository, ISessionFactory session)
        {
            _classRepository = classRepository;
            _session = session;
        }

        public void Addnewstudent(Student student)
        {
            using (var session =_session.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(student);
                        transaction.Commit();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine($"Error message :{ex.Message}");
                        transaction.Rollback();
                    }
                }    
            }    
            throw new NotImplementedException();
        }

        public void Deletestudent(Student student)
        {
            using (var session = _session.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(student);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error message :{ex.Message}");
                        transaction.Rollback();
                    }
                }
            }
            throw new NotImplementedException();
        }

        public void Findstudentbyname()
        {
            throw new NotImplementedException();
        }

        public List<Student> GetSinhviens()
        {
            throw new NotImplementedException();
        }

        public List<Student> Sortbyname()
        {
          
            throw new NotImplementedException();
        }

        public void Updatenewstudent(Student studentUpdate)
        {
            using (var session = _session.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(studentUpdate);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error message :{ex.Message}");
                        transaction.Rollback();
                    }
                }
            }
            throw new NotImplementedException();
        }
    }

    
}
