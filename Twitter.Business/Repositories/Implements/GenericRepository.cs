using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Business.Repositories.Interfaces;
using Twitter.CORE.Entities.Common;
using Twitter.DAL.Contexts;

namespace Twitter.Business.Repositories.Implements
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        TwitterContext _twitterContext;

        public GenericRepository(TwitterContext twitterContext)
        {
            _twitterContext = twitterContext;
        }
        public DbSet<T> Table => _twitterContext.Set<T>();
        public IQueryable<T> GetAll(bool noTracking = true)
            => noTracking ? Table.AsNoTracking() : Table;
    }
}
