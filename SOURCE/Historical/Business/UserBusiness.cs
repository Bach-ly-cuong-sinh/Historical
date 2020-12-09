using Historical.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Historical.Business
{
    public class UserBusiness : GenericBusiness
    {
        public User Login(string User_Name, string Pasword)
        {
            try
            {
                User data = new User();
                var query = from u in cnn.Users
                            where u.Name.Equals(User_Name) && u.IsActive == 1 && u.Password.Equals(Pasword)
                            select (new User()
                            {
                                Id = u.Id,
                                Name = u.Name,
                                CreatedDate = u.CreatedDate
                            });

                if(query != null)
                {
                    data = query.FirstOrDefault();
                    return data;
                }
                return new User();
            }
            catch(Exception e)
            {
                e.ToString();
                return new User();
            }
        }        
    }
}
