using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineStore.Core
{
    public interface IUserInfo
    {
        string Domain { get; set; }

        string Name { get; set; }

        string[] Roles { get; set; }

    }
}
