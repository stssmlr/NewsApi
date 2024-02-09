using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Interfaces
{
    public interface ITemplateService<T>
    {
        Task Insert(T model);
        Task Update(T news);
        Task Delete(int id);
        Task<T> Get(int id);
        Task<List<T>> GetAll();
    }
}
