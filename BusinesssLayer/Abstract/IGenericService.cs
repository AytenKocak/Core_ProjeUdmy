using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinesLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetByID(int id);
        List<T> TGetListbyFilter(Expression<Func<T, bool>> filter); // 
    }
}
