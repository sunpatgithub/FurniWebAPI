using Furni.Domain.Entities;
using Furni.Domain.Interface;
using System.Diagnostics;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore.Storage;


namespace Furni.Infrastructure.Data
{
    public class UnitOfWork : Disposable, IUnitOfWork
    {
        //private readonly IDatabaseFactory databaseFactory;
        //private CNAPIEntities dataContext;
        //private DbContextTransaction _transaction = null;
        private IDbContextTransaction _transaction = null;
        //  private readonly CNAPIEntities _context;
        //private bool disposed;
        //private Dictionary<string, object> repositories;
        //private IRepository<UserRegister> _userRegisterRepository;
        //private IRepository<UserLog> _userLogRepository;
        //private IRepository<UserActionLog> _userActionLogRepository;
        //private IRepository<AdminUser> _adminUserRepository;
        //private IRepository<ServiceSubscription> _serviceSubscripitio;

        //public UnitOfWork(DatabaseContext databaseContext)
        //{ _databaseContext = databaseContext; }


        private furniContext _context = null;
        public UnitOfWork()
        {
            _context = new furniContext();
        }

        //public Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        //public IRepository<T> Repository<T>() where T : class
        //{
        //    if (repositories == null)
        //    {
        //        repositories = new Dictionary<Type, object>();
        //    }
        //    if (repositories.ContainsKey(typeof(T)) == true)
        //    {
        //        return repositories[typeof(T)] as IRepository<T>;
        //    }
        //    IRepository<T> repo = new Repository<T>(_context);
        //    repositories.Add(typeof(T), repo);
        //    return repo;
        //}


        //public IRepository<UserLog> UserLogRepository
        //{ 
        //    get
        //    {
        //        if (this._userLogRepository == null)
        //        {
        //            this._userLogRepository = new Repository<UserLog>(_context);
        //        }
        //        return this._userLogRepository;
        //    }
        //}

        //public IRepository<UserRegister> UserRegisterRepository
        //{
        //    get
        //    {
        //        if (this._userRegisterRepository == null)
        //        {
        //            this._userRegisterRepository = new Repository<UserRegister>(_context);
        //        }
        //        return this._userRegisterRepository;
        //    }
        //}

       

        public void BeginTransaction()
        {
            // _context.Database.BeginTransaction();           
            _transaction = _context.Database.BeginTransaction();           
        }


        public string Commit()
        {
            var outputLines = new List<string>();
            string stroutput = string.Empty;
            try
            {               
                _context.SaveChanges();
                 _transaction.Commit();
                //_context.Database.CommitTransaction();
            }
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            Trace.TraceInformation("Class: {0}, Property: {1}, Error: {2}", validationErrors.Entry.Entity.GetType().FullName,
            //                          validationError.PropertyName, validationError.ErrorMessage);
            //            outputLines.Add(string.Format("- Property: \"{0}\", Error: \"{1}\"", validationError.PropertyName, validationError.ErrorMessage));
            //        }
            //    }
            //    stroutput = string.Join(",", outputLines.ToArray());
            //    //System.IO.File.AppendAllLines(@"C:\errors.txt", outputLines);
            //}           
            catch(Exception ex)
            {
                stroutput = ex.Message;
                _transaction.Rollback();                
                //_context.Database.RollbackTransaction();
            }
            finally
            {
                _transaction = _context.Database.BeginTransaction();
                //_context.Database.BeginTransaction();
            }
            return stroutput;
        }

       
    }
}
