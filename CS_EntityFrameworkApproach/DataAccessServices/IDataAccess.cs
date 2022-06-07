using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EntityFrameworkApproach.DataAccessServices
{
    public interface IDataAccess<TEntity, in TPk> where TEntity :class
    {
        IEnumerable<TEntity> Get();
        TEntity Get(TPk id); 
        TEntity Create(TEntity entity); 
        TEntity Update(TPk id, TEntity entity); 
        TEntity Delete(TPk id);
    }
}
