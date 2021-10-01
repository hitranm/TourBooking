using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataAccess;

namespace DataAccess.Repository
{
    public class UserRepository: IUserRepository
    {
        public IEnumerable<TblUser> GetUsers() => UserDAO.Instance.GetUserList();
        public TblUser GetUserByID(int UserID) => UserDAO.Instance.GetUserByID(UserID);
        public void InsertUser(TblUser user) => UserDAO.Instance.AddNew(user);
        public void DeleteUser(int UserID) => UserDAO.Instance.Remove(UserID);
        public void UpdateUser(TblUser user) => UserDAO.Instance.Update(user);

    }
}
