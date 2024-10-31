using System;
using System.Linq;
using Models;

namespace Services
{
    public class BrandService
    {
        private readonly DbContext _context;

        public BrandService(DbContext context)
        {
            _context = context;
        }

        public void AssociateSubcollection(int brandId, int subcollectionId)
        {
            var brand = _context.Brands.Find(brandId);
            var subcollection = _context.Subcollections.Find(subcollectionId);

            if (brand == null || subcollection == null)
                throw new ArgumentException("Invalid brand or subcollection ID.");

            brand.Subcollections.Add(subcollection);
            _context.SaveChanges();
        }

        public void DisassociateSubcollection(int brandId, int subcollectionId)
        {
            var brand = _context.Brands.Find(brandId);
            var subcollection = _context.Subcollections.Find(subcollectionId);

            if (brand == null || subcollection == null)
                throw new ArgumentException("Invalid brand or subcollection ID.");

            brand.Subcollections.Remove(subcollection);
            _context.SaveChanges();
        }

        public bool BrandExists(int brandId)
        {
            return _context.Brands.Any(b => b.Id == brandId);
        }

        public bool SubcollectionExists(int subcollectionId)
        {
            return _context.Subcollections.Any(s => s.Id == subcollectionId);
        }
    }

    }
}
