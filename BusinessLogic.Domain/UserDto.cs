﻿using System.Collections.Generic;

namespace BusinessLogic.Domain
{
    public class UserDto : DtoBase<long>
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public virtual ICollection<RoleDto> Roles { get; set; }
    }
}
