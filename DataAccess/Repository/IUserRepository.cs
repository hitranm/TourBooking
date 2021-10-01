using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataAccess;
namespace DataAccess.Repository
{
    public interface IUserRepository
    {
        IEnumerable<TblUser> GetUsers();
        TblUser GetUserByID(int UserID);
        void InsertUser(TblUser user);
        void DeleteUser(int UserID);
        void UpdateUser(TblUser user);
        
    }
}
