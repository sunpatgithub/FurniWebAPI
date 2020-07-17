using System;
using System.Collections.Generic;
using System.Text;
using Furni.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Furni.Domain.Entities;
using System.Data.SqlClient;

namespace Furni.Infrastructure.Data
{
    public class ADORepository
    {

    }

    public class ADORepository<T> : IADORepository<T> where T : class
    {
        private bool disposed = false;

        #region Context       


        private DbSet<T> dbSet;
        public DbContext context;

        //Uncomment the below code if you dont want to use database factory class and comment the code related to database factory connection.
        public ADORepository()
        {
            context = new furniContext();
            //dbSet = context.Set<T>();
        }

        #endregion


        #region GenRepository

        //public int GetList(string query, params object[] parameters)
        //{
        //    return context.Database.ExecuteSqlCommand(query, parameters);
        //}




        /// <summary>
        /// Get Data From Database
        /// <para>Use it when to retive data through a stored procedure</para>
        /// </summary>
        public List<T> ExecuteQuery(string spQuery, object[] parameters)
        {
            return context.Database.SqlQuery<T>(spQuery, parameters).ToList();
        }

        /// <summary>
        /// Get Data From Database
        /// <para>Use it when to retive data through a stored procedure</para>
        /// </summary>
        public List<T> ExecuteQuery(string spQuery)
        {
            return context.Database.SqlQuery<T>(spQuery).ToList();
        }


        /// <summary>
        /// Get Single Data From Database
        /// <para>Use it when to retive single data through a stored procedure</para>
        /// </summary>
        public T ExecuteQuerySingle(string spQuery, object[] parameters)
        {
            return context.Database.SqlQuery<T>(spQuery, parameters).FirstOrDefault();
        }


        public T ExecuteQuerySingle(string spQuery)
        {
            return context.Database.SqlQuery<T>(spQuery).FirstOrDefault();
        }

        /// <summary>
        /// Insert/Update/Delete Data To Database
        /// <para>Use it when to Insert/Update/Delete data through a stored procedure</para>
        /// </summary>
        public decimal ExecuteSP(string spQuery, object[] parameters)
        {
            // return context.Database.ExecuteSqlCommand(spQuery, parameters)    
            return context.Database.SqlQuery<decimal>(spQuery, parameters).FirstOrDefault();
        }

        public double ExecuteSPdouble(string spQuery, object[] parameters)
        {
            // return context.Database.ExecuteSqlCommand(spQuery, parameters)    
            return context.Database.SqlQuery<double>(spQuery, parameters).FirstOrDefault();
        }

        public byte ExecuteSPbyte(string spQuery, object[] parameters)
        {
            // return context.Database.ExecuteSqlCommand(spQuery, parameters)    
            return context.Database.SqlQuery<byte>(spQuery, parameters).FirstOrDefault();
        }

        public bool ExecuteSPBool(string spQuery, object[] parameters)
        {
            // return context.Database.ExecuteSqlCommand(spQuery, parameters)    
            return context.Database.SqlQuery<bool>(spQuery, parameters).FirstOrDefault();
        }

        //Without Parameter
        public int ExecuteCommand(string spQuery)
        {
            int result = 0;
            try
            {
                result = context.Database.SqlQuery<int>(spQuery).FirstOrDefault();
            }
            catch { }
            return result;
        }

        public void ExecuteCommand(string spQuery, object[] parameters)
        {
            context.Database.SqlQuery<T>(spQuery, parameters);
        }


        //  private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }







        #endregion
    }
}
