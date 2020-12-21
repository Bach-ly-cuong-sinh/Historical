using Historical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Historical.Business
{
    public class RelicsBusiness:GenericBusiness
    {
        public List<RelicsOutputModel> ListRelic()
        {
            try
            {
                List<RelicsOutputModel> data = new List<RelicsOutputModel>();
                var q = from r in cnn.Relics
                        where r.IsActive.Equals(1)
                        orderby r.Id descending
                        select (new RelicsOutputModel()
                        {
                            CategoryID = r.Cate.Id,
                            CategoryName = r.Cate.Name,
                            Address = r.Address,
                            CreatedDate = r.CraetedDate.Value,
                            ImageUrl = r.ImageUrl,
                            MapUrl = r.MapLinks,
                            RelicsName = r.Name,
                            RelicsID = r.Id
                        });
                if (q != null)
                {
                    data = q.ToList();
                    return data;
                }

                return new List<RelicsOutputModel>();
            }
            catch
            {
                return new List<RelicsOutputModel>();
            }
        }
    }
}
