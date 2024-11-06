using System.Collections.Generic;
using Src.Models;

namespace Src.Repositories
{
    public class SellerRepository
    {
        private readonly List<Seller> _sellers = new List<Seller>();

        public Seller GetSellerById(int id)
        {
            return _sellers.Find(s => s.Id == id);
        }

        public void AddSeller(Seller seller)
        {
            _sellers.Add(seller);
        }

        public void UpdateSeller(Seller seller)
        {
            var existingSeller = GetSellerById(seller.Id);
            if (existingSeller != null)
            {
                existingSeller.Name = seller.Name;
                existingSeller.ContactInfo = seller.ContactInfo;
            }
        }
    }
}
