using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapDBContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var result = from cu in context.Customers
                             join u in context.Users
                             on cu.UserId equals u.Id
                             select new CustomerDetailDto
                             {
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 CompanyName = cu.CompanyName

                             };

                return result.ToList();

            }
        }
    }
}
