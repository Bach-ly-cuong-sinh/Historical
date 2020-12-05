using Historical.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Historical.Models
{
    public interface IStoreRepository
    {
        IQueryable<Relic> relics { get; }
    }
}
