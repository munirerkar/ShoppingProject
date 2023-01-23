using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        IMapper _mapper;

        public CustomerManager(ICustomerDal customerDal, IMapper mapper)
        {
            _customerDal = customerDal;
            _mapper = mapper;
        }

        public IResult CreateCustomer(CustomerDto customerDto)
        {
            var map = _mapper.Map<Customer>(customerDto);
            _customerDal.Add(map);
            return new SuccessResult(Messages.Added);
        }

        public IResult DeleteCustomer(CustomerDto customerDto)
        {
            var map = _mapper.Map<Customer>(customerDto);
            _customerDal.Delete(map);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<CustomerDto>> GetAllCustomers()
        {
            var map = _mapper.Map<List<CustomerDto>>(_customerDal.GetAll());
            return new SuccessDataResult<List<CustomerDto>>(map);
        }

        public IResult UpdateCustomer(CustomerDto customerDto)
        {
            var map = _mapper.Map<Customer>(customerDto);
            _customerDal.Update(map);
            return new SuccessResult(Messages.Updated);
        }
    }
}
