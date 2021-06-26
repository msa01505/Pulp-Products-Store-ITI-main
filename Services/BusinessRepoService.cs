
using Pulp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pulp.Services
{
    public class BusinessRepoService : IBusinessRepoService
    {
        private readonly myContext context;
        public BusinessRepoService(myContext _context)
        {
            context = _context;
        }
        public Business SearchByName(string name)
        {
            return context.Businesses.FirstOrDefault(r => r.Name == name);
        }
        public List<Business> Search(string name)
        {
            return context.Businesses.Where(r => r.Name.Contains(name)).ToList();
        }
        public void DeleteBusinesses(int id)
        {
            context.Remove(context.Businesses.FirstOrDefault(r => r.BusinessID == id));
            context.SaveChanges();
        }

        public List<Business> GetAllBusinessess()
        {
            return context.Businesses.ToList();
        }

        public Business GetDetails(int? id)
        {
            return context.Businesses.FirstOrDefault(r => r.BusinessID == id);
        }

        public void Insert(Business business)
        {
            context.Businesses.Add(business);
            context.SaveChanges();
        }

        public bool BusinessExists(int id)
        {
            return context.Businesses.Any(r => r.BusinessID == id);
        }

        public void UpdateBusiness(int id, Business business)
        {
            Business businessUpdated = context.Businesses.FirstOrDefault(r => r.BusinessID == id);
            businessUpdated.Name = business.Name;
            businessUpdated.Describtion = business.Describtion;
            context.SaveChanges();
        }
    }
}
