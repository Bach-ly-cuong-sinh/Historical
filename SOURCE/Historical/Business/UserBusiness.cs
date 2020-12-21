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
                        orderby u.Id ,u.IsActive descending
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
        public List<UserOutputModel> DeleteUser(int Id)
        {
            try
            {
                var user = cnn.Users.Find(Id);
                if (user.IsActive.Equals(1))
                {
                    user.IsActive = 0;
                    cnn.SaveChanges();
                }
                return this.ListUser();
            }
            catch
            {
                return this.ListUser();
            }
        }
        public List<UserOutputModel> SuccessUser(int Id)
        {
            try
            {
                var user = cnn.Users.Find(Id);
                if (user.IsActive.Equals(0))
                {
                    user.IsActive = 1;
                    cnn.SaveChanges();
                }
                return this.ListUser();
            }
            catch
            {
                return this.ListUser();
            }
        }
        public List<UserOutputModel> CreateUser(string Name, string Password)
        {
            try
            {
                User u = new User();
                u.Name = Name;
                u.Password = Password;
                u.IsActive = 1;
                u.CreatedDate = DateTime.Now;
                cnn.Add(u);
                cnn.SaveChanges();
                return this.ListUser();
            }
            catch
            {
                return this.ListUser();
            }
        }
    }
}
