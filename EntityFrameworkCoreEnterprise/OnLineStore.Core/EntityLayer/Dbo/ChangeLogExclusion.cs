using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineStore.Core.EntityLayer.Dbo
{
    public class ChangeLogExclusion: IEntity
    {
        public ChangeLogExclusion()
        {
        }

        public int? ChangeLogExclusionID { get; set; }

        public string EntityName { get; set; }

        public string PropertyName { get; set; }

    }
}
