using System;
using System.Collections.Generic;
using System.Text;

namespace Furni.Domain.Interface
{    
    public interface IADORepository<T> : IDisposable where T : class
    {
        List<T> ExecuteQuery(string spQuery);

        List<T> ExecuteQuery(string spQuery, object[] parameters);

        T ExecuteQuerySingle(string spQuery, object[] parameters);

        T ExecuteQuerySingle(string spQuery);

        decimal ExecuteSP(string spQuery, object[] parameters);

        byte ExecuteSPbyte(string spQuery, object[] parameters);

        bool ExecuteSPBool(string spQuery, object[] parameters);

        int ExecuteCommand(string spQuery);

        void ExecuteCommand(string spQuery, object[] parameters);

        double ExecuteSPdouble(string spQuery, object[] parameters);
    }
}
