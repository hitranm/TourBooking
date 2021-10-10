using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CustomerDAO
    {
        private static CustomerDAO instance = null;
        private static readonly object instanceLock = new object();
        private CustomerDAO() { }
        public static CustomerDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<TblCustomer> GetCustomersList()
        {
            var customers = new List<TblCustomer>();
            try
            {
                using var context = new TourContext();
                customers = context.TblCustomers.ToList();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customers;
        }
        public TblCustomer GetCustomerByID(int customerID)
        {
            TblCustomer customer = null;
            try
            {
                using var context = new TourContext();
                customer = context.TblCustomers.SingleOrDefault(c => c.CustomerId == customerID);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customer;
        }
        public void AddNew(TblCustomer customer)
        {
            try
            {
                TblCustomer cust = GetCustomerByID(customer.CustomerId);
                if (cust == null)
                {
                    using var context = new TourContext();
                    context.TblCustomers.Add(customer);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The customer is already exist.");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(TblCustomer customer)
        {
            try
            {
                TblCustomer cust = GetCustomerByID(customer.CustomerId);
                if (cust != null)
                {
                    using var context = new TourContext();
                    context.TblCustomers.Update(customer);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The customer does not exist.");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Remove(int customerID)
        {
            try
            {
                TblCustomer customer = GetCustomerByID(customerID);
                if (customer != null)
                {
                    using var context = new TourContext();
                    context.TblCustomers.Remove(customer);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The customer does not exist.");
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public TblCustomer SearchCustomer(string phoneNum)
        {
            TblCustomer customer = null;
            try
            {
                using var context = new TourContext();
                customer = context.TblCustomers.SingleOrDefault(c => c.PhoneNo == phoneNum);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customer;
        }
    }
}
