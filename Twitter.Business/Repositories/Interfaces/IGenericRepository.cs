using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.CORE.Entities.Common;

namespace Twitter.Business.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T:BaseEntity
    {
        DbSet<T> Table { get; }
        IQueryable<T> GetAll(bool noTracking = true); 
    }
}
