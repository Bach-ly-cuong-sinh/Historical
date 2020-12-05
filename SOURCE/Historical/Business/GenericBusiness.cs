using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Historical.Models;

namespace Historical.Business
{
    public class GenericBusiness:Models.IStoreRepository
    {
        public HistoricalContext context;
        public HistoricalContext cnn;
        public GenericBusiness(HistoricalContext context = null)
        {
            if (context == null)
            {
                this.context = new HistoricalContext();
            }
            cnn = this.context;
        }
        public IQueryable<Models.Relic> relics => context.Relics;
    }
}
