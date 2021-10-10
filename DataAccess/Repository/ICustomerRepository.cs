using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<TblCustomer> GetCustomers();
        TblCustomer GetCustomerByID(int customerID);
        void InsertCustomer(TblCustomer customer);
        void UpdateCustomer(TblCustomer customer);
        void DeleteCustomer(int customerID);
        TblCustomer SearchCustomer(string phoneNo);
    }
}
