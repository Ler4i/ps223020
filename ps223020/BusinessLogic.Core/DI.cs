using ps223020.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ps223020.BusinessLogic.Core
{
    public class DI//инъекция зависимости 
    {
        private readonly Context _context;
        public DI(Context context)
        {
            _context = context;
        }
    }
}
