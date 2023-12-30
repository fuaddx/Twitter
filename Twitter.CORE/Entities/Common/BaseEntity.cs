using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.CORE.Entities.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public virtual DateTime CreatedTime { get; set; }
        public virtual bool IsDeleted { get; set; }
    }
}
