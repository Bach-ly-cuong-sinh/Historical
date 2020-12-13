using Historical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Historical.Business
{
    public class FeedBackBusiness:GenericBusiness
    {
        public List<FeedBackOutputModel> ListFeedBack()
        {
            try
            {
                List<FeedBackOutputModel> data = new List<FeedBackOutputModel>();
                var q = from f in cnn.Feedbacks
                        where (f.IsActive.Equals(1))
                        orderby f.Id descending
                        select (new FeedBackOutputModel()
                        {
                            Id = f.Id,
                            Content =f.Content,
                            CreatedDate=f.CreatedDate,
                            IsActive =f.IsActive,
                            RelicId = f.RelicId,
                            RelicName = f.Relic.Name
                        });
                if (q != null)
                {
                    data = q.ToList();
                    return data;
                }
                return new List<FeedBackOutputModel>();
            }
            catch
            {
                return new List<FeedBackOutputModel>();
            }
        }
    }
}
