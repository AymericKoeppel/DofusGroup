using DofusGroup.Data.DB;
using DofusGroup.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DofusGroup.Data.Implementations
{
    public class ClassService
    {

        private DofusContext _context;

        public ClassService(DofusContext context)
        {
            _context = context;
        }

        public async Task<List<Class>> GetAllClasses()
        {
            return  _context.Class.ToList();
        }
    }
}
