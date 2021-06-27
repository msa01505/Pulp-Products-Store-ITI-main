using Pulp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pulp.Services
{
    public interface IBusinessRepoService
    {
        public List<Business> Search(string name);
        public List<Business> GetAllBusinessess();
        public Business GetDetails(int? id);
        public Business SearchByName(string name);
        public void Insert(Business business);
        public void UpdateBusiness(int id, Business business);
        public void DeleteBusinesses(int id);
        public bool BusinessExists(int id);
    }

}
