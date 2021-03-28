using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapDBContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var result = from re in context.Rentals
                             join c in context.Cars
                             on re.CarId equals c.Id
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cu in context.Customers
                             on re.CustomerId equals cu.CustomerId
                             join u in context.Users
                             on cu.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 RentalId = re.Id,
                                 BrandName = b.BrandName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate
                   
                             };
                return result.ToList();

            }
        }
    }
}
