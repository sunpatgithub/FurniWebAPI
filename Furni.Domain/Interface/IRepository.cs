using System;
using System.Collections.Generic;
using System.Text;

namespace Furni.Domain.Interface
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetById(object Id);

        void Add(T obj);

        string Delete(object Id);

        void DeleteObj(T entityToDelete);

        string Update(T obj);

        T InsertObj(T obj);

        string Insert(T obj);

        T Single(Func<T, bool> exp);
        /// <summary>Returns the first element satisfying the condition.</summary>
        /// <param name="exp"></param><returns></returns>
        T First(Func<T, bool> exp);        /// <summary>       
        T FirstOrDefault(Func<T, bool> exp);

        IEnumerable<T> GetMany(Func<T, bool> where);

        bool ItemExists(Func<T, bool> where);

        void BeginTransaction();

        string Commit();

        string SaveAll();
    }
}
