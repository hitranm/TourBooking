using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        public IEnumerable<TblCustomer> GetCustomers() => CustomerDAO.Instance.GetCustomersList();
        public TblCustomer GetCustomerByID(int customerID) => CustomerDAO.Instance.GetCustomerByID(customerID);
        public void InsertCustomer(TblCustomer customer) => CustomerDAO.Instance.AddNew(customer);
        public void UpdateCustomer(TblCustomer customer) => CustomerDAO.Instance.Update(customer);
        public void DeleteCustomer(int customerID) => CustomerDAO.Instance.Remove(customerID);
        public TblCustomer SearchCustomer(string phoneNo) => CustomerDAO.Instance.SearchCustomer(phoneNo);
    }
}
