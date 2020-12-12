using Historical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Historical.Business
{
    public class ListBusiness:GenericBusiness
    {
        public RelicsOutputModel Detail(int ID)
        {
            try
            {
                RelicsOutputModel data = new RelicsOutputModel();
                var query = from c in cnn.Relics
                            where (c.Id.Equals(ID))
                            select (new RelicsOutputModel()
                            {
                                RelicsID = c.Id,
                                CategoryID = c.CateId,
                                RelicsName = c.Name,
                                CategoryName = c.Cate.Name,
                                CreatedDate = c.CraetedDate.Value,
                                Address = c.Address,
                                ImageUrl = c.ImageUrl
                            });
                if(query != null)
                {
                    data = query.FirstOrDefault();
                    return data;
                }
                return new RelicsOutputModel();
            }
            catch (Exception e)
            {
                e.ToString();
                return new RelicsOutputModel();
            }
        }
    }
}
