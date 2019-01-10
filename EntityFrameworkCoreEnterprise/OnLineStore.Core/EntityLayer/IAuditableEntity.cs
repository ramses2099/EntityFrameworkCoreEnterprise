using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineStore.Core.EntityLayer
{
    public interface IAuditableEntity : IEntity
    {
        String CreationUser { get; set; }
        DateTime? CreationDateTime { get; set; }
        String LastUpdateUser { get; set; }
        DateTime? LastUpdateDateTime { get; set; }

    }
}
