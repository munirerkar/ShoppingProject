using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.Customer;
using Entities.DTOs.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<CustomerDto>> GetAllCustomers();
        IResult CreateCustomer(CustomerAddDto customerAddDto);
        IResult UpdateCustomer(CustomerDto customerDto);
        IResult DeleteCustomer(CustomerDto customerDto);
    }
}
