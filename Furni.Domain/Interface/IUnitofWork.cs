using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Furni.Domain.Entities;

namespace Furni.Domain.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        string Commit();
        // void Rollback();

        // IRepository<T> Repository<T>() where T : class;

        //Multiple Repositories

        //IRepository<UserLog> UserLogRepository { get; }
        //IRepository<UserRegister> UserRegisterRepository { get; }
        //IRepository<UserActionLog> UserActionLogRepository { get; }
        //IRepository<AdminUser> AdminUserRepository { get; }
        //IRepository<ServiceSubscription> serviceSubscripitio { get; }

    }
}
