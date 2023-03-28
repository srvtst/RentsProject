using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Absctract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new Result(true, Message.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new Result(true,Message.CustomerDeleted);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new Result(true, Message.CustomerUpdated);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),Message.CustomerListed);
        }

        public IDataResult<Customer> GetByCustomerId(int customerid)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.Id == customerid));
        }

    }
}
