using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Domain
{
    public class DtoBase<TKeyType>
    {
        public TKeyType Id { get; set; }
    }
}
