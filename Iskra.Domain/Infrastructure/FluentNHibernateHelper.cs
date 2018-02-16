using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Iskra.Domain;
using NHibernate;

namespace Iskra.Infrastructure
{
    public class FluentNHibernateHelper
    {
        public ISessionFactory SessionFactory { get; private set; }

        public FluentNHibernateHelper()
        {
            try
            {
                SessionFactory = Fluently.Configure()
                    .Database(PostgreSQLConfiguration.PostgreSQL82
                    .ConnectionString(c => c
                    .Host("25.62.155.189")
                    .Port(5432)
                    .Database("test_fitness")
                    .Username("postgres")
                    .Password("123")))
                    .Mappings(x => x.FluentMappings.AddFromAssemblyOf<Program>())
                    .BuildSessionFactory();
            }
            catch (Exception e)
            {
                return;
            }
        }
    }
}
