﻿using FluentNHibernate.MappingModel.ClassBased;
using gRPCqlsinhvien.Mapping;
using Microsoft.Extensions.DependencyInjection;
using NHibernate;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
//using Quanlysinhvien.Mapping;
//using Quanlysinhvien.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Configuration = NHibernate.Cfg.Configuration;

namespace gRPCqlsinhvien
{
    public static class NHibernateConfig
    {
        public static ISessionFactory BuildSessionFactory()
        {
            var cfg = new Configuration();
            string connectionString = "Data Source=DESKTOP-CGRP2Q4\\HOO;Initial Catalog=quanlisinhvien;User Id =hieuhoo ;Password=123456 ;"; //ket noi voi co so du lieu db

            cfg.DataBaseIntegration(db =>
            {
                db.ConnectionString = connectionString;
                db.Dialect<MsSql2012Dialect>();
                db.Driver<SqlClientDriver>();
            });
            var mapper = new ModelMapper();
            mapper.AddMapping(typeof(StudentMapping));
            mapper.AddMapping(typeof(ClassMapping));
            mapper.AddMapping(typeof(TeacherMapping));

            HbmMapping domainMapping = mapper.CompileMappingForAllExplicitlyAddedEntities();
            cfg.AddMapping(domainMapping);

           // var sessionFactory = cfg.BuildSessionFactory();

            //services.AddSingleton<ISessionFactory>(sessionFactory);
            //services.AddScoped<ISession>(provider => provider.GetRequiredService<ISessionFactory>().OpenSession());

            return cfg.BuildSessionFactory();
        }
    }

}

