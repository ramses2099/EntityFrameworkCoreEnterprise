using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineStore.Core
{
    public class UserInfo : IUserInfo
    {
        public UserInfo() { }
        public UserInfo(String name)
        {
            Name = name;
        }

        public string Domain { get; set; }
        public string Name { get; set; }
        public string[] Roles { get; set; }
    }
}
