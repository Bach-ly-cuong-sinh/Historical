using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Historical.Model;
using Historical.Models;

namespace Historical.Business
{
    public class GenericBusiness:IStoreRepository
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
        public IQueryable<Relic> relics => context.Relics;
    }
}
