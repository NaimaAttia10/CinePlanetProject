using ProjectMidTerm.Data;
using ProjectMidTerm.Data.Base;
using ProjectMidTerm.Data.Services;
using ProjectMidTerm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMidTerm.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
