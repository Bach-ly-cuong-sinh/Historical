using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Historical.Model;

namespace Historical.Business
{
    public class GenericBusiness
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

    }
}
