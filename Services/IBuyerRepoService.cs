using Pulp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pulp.Services
{
    public interface IBuyerRepoService
    {
        public List<Buyer> GetAllBuyers();
        public Buyer GetBuyerByUsername(string buyerUsername);
        public Buyer GetDetails(int? id);
        public void Insert(Buyer buyer);
        public void UpdateBuyer(int id, Buyer buyer);
        public void DeleteBuyer(int id);
        public bool BuyerExists(int id);
    }
}
