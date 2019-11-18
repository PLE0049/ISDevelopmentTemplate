using System;
using System.Collections.Generic;
using System.Text;
using TeamScheduler.Core.DataMappers;

namespace TeamScheduler.Infrastructure.DataMappers
{
    public class GeneridMapper<T> : IGenericMapper<T> where T : class, new()
    {
        public bool Create(T user)
        {
            var tabelName = typeof(T).FullName;
            var properties = typeof(T).GetProperties();

            // Construct SQL Query 
            var query = "Select * from " + tabelName + " where id = ";

            // Execute SQL query;
            var colName = properties[0].Name;

            var instance = new T();
            foreach (var property in properties)
            {
                property.SetValue(instance, "");
            }

            throw new NotImplementedException();
        }

        public bool Delete(T user)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T Update(T user)
        {
            throw new NotImplementedException();
        }
    }
}
