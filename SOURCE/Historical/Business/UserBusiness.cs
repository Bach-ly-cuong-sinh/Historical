using Historical.Model;
using Historical.Models;
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
        public List<UserOutputModel> ListUser()
        {
            try
            {
                List<UserOutputModel> data = new List<UserOutputModel>();
                var q = from u in cnn.Users
                        where u.IsActive.Equals(1)
                        orderby (u.Id)
                        select (new UserOutputModel()
                        {
                            Id = u.Id,
                            Name = u.Name,
                            Password = u.Password,
                            IsActive = u.IsActive,
                            CreatedDate = u.CreatedDate
                        });
                if(q != null)
                {
                    data = q.ToList();
                    return data;
                }
                return new List<UserOutputModel>();
            }
            catch
            {
                return new List<UserOutputModel>();
            }
        }
    }
}
