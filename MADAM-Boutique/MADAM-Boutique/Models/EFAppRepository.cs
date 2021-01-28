using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MADAM_Boutique.Models;

namespace MADAM_Boutique.Models
{
    public class EFAppRepository : IProductRepository
    {
        private AppDbContext context;

        public EFAppRepository(AppDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
