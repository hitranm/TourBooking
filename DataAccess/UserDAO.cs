using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataAccess;
namespace DataAccess
{
    public class UserDAO
    {
        //Using Singleton Pattern
        private static UserDAO instance = null;
        private static readonly object instanceLock = new object();
        private UserDAO() { }
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<TblUser> GetUserList()
        {
            var users = new List<TblUser>();
            try
            {
                using var context = new TourContext();
                users = context.TblUsers.ToList();
            }
            catch (Exception e)
            {
                    throw new Exception(e.Message);
            }
            return users;

        }

        public TblUser GetUserByID(int UserID)
        {
            TblUser user = null;
            try
            {
                using var context = new TourContext();
                user = context.TblUsers.SingleOrDefault(c => c.UserId == UserID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return user;
        }

        //-----------------------------------------------------------------
        //Add a new user
        public void AddNew(TblUser user)
        {
            try
            {
                TblUser use = GetUserByID(user.UserId);
                if (use == null)
                {
                    using var context = new TourContext();
                    context.TblUsers.Add(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The user is already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //-----------------------------------------------------------------
        //Add a new user
        public void Update(TblUser user)
        {
            try
            {
                TblUser mem = GetUserByID(user.UserId);
                if (mem != null)
                {
                    using var context = new TourContext();
                    context.TblUsers.Update(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The user does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //-----------------------------------------------------------------
        //Add a new user
        public void Remove(int UserID)
        {
            try
            {
                TblUser mem = GetUserByID(UserID);
                if (mem != null)
                {
                    using var context = new TourContext();
                    context.TblUsers.Remove(mem);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The user does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
       
    }
}
