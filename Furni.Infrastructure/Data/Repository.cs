using System;
using System.Collections.Generic;
//using System.Data.Entity;
//using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using Furni.Domain.Entities;
using Furni.Domain.Interface;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;

namespace Furni.Infrastructure.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        #region Context       

        //private CNAPIEntities context;
        private DbSet<T> dbSet;
        private IDbContextTransaction transaction = null;
        public DbContext context;

      
        //public Repository(CNAPIEntities _entities)
        //{
        //    //  DatabaseFactory = databaseFactory;
        //    // context = new CNAPIEntities();
        //    context = _entities;
        //    dbSet = context.Set<T>();
        //}

        //Uncomment the below code if you dont want to use database factory class and comment the code related to database factory connection.
        public Repository()
        {
            context = new furniContext();
            context.ChangeTracker.LazyLoadingEnabled = false;            
           // context.Configuration.ProxyCreationEnabled = false;
            dbSet = context.Set<T>();
        }

        public Repository(DbContext _entities)
        {
            context = _entities;
            context.ChangeTracker.LazyLoadingEnabled = false;
            // context.Configuration.ProxyCreationEnabled = false;
            dbSet = context.Set<T>();
        }

        #endregion

        #region Repository

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(object id)
        {
            return dbSet.Find(id);
        }

        public T InsertObj(T obj)
        {
            try
            {
                //  BeginTransaction();
                dbSet.Add(obj);
                context.SaveChanges();
            }
            catch(Exception e)
            {
                transaction.Rollback();
            }
            finally
            {
                //transaction = context.Database.BeginTransaction();
            }
            // Commit();
            return obj;
        }

        public string Insert(T obj)
        {
            BeginTransaction();
            dbSet.Add(obj);
            context.SaveChanges();
            return Commit();
        }

        public void Add(T obj)
        {
            dbSet.Add(obj);
            // context.SaveChanges();
            //return obj;
        }

        public string Delete(object id)
        {
            BeginTransaction();
            T entityToDelete = dbSet.Find(id);
            DeleteObj(entityToDelete);
            context.SaveChanges();
            return Commit();
        }
        public void DeleteObj(T entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
            context.SaveChanges();
        }
        //public T Update(T obj)
        //{
        //    dbSet.Attach(obj);
        //    context.Entry(obj).State = EntityState.Modified;
        //    //context.SaveChanges();
        //    return obj;
        //}

        public string Update(T obj)
        {
            BeginTransaction();
            dbSet.Attach(obj);
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
            return Commit();
        }

        public T Single(Func<T, bool> exp)
        {
            return dbSet.Single(exp);
        }

        public T First(Func<T, bool> exp)
        {
            return dbSet.First(exp);
        }

        public T FirstOrDefault(Func<T, bool> exp)
        {
            return dbSet.FirstOrDefault(exp);
        }

        public IEnumerable<T> GetMany(Func<T, bool> where)
        {
            return dbSet.Where(where).ToList();
        }

        public bool ItemExists(Func<T, bool> where)
        {
            return dbSet.Any(where);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (context != null)
                {
                    context.Dispose();
                    context = null;
                }
            }
        }

        #endregion
        
        #region Unit of Work       

        public void BeginTransaction()
        {
            transaction = context.Database.BeginTransaction();
        }

        public string SaveAll()
        {
            var outputLines = new List<string>();
            string stroutput = string.Empty;
            try
            {
                context.SaveChanges();
                transaction.Commit();
            }           
            catch (Exception ex)
            {
                stroutput = ex.Message;
                transaction.Rollback();
            }
            finally
            {
                transaction = context.Database.BeginTransaction();

            }
            return stroutput;
        }


        public string Commit()
        {
            var outputLines = new List<string>();
            string stroutput = string.Empty;
            try
            {
                transaction.Commit();
            }           
            catch
            {
                transaction.Rollback();
            }
            finally
            {
                transaction = context.Database.BeginTransaction();
                stroutput = string.Join(",", outputLines.ToArray());
            }
            return stroutput;
        }

        

        #endregion
        
    }

}