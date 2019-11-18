using System;
using System.Collections.Generic;
using System.Text;

namespace TeamScheduler.Core.DataMappers
{
    public interface IGenericMapper<T>
    { 
        IEnumerable<T> GetAll();
        T Get(int id);
        T Update(T user);
        bool Create(T user);
        bool Delete(T user);
    }
}
