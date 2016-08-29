using ShoppingStoreOnline.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingStoreOnline.Domain.Entities;

namespace ShoppingStoreOnline.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private readonly EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
