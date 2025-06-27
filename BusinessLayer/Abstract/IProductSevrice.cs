using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductSevrice:IGenericSevrice<Product>
    {
        List<Product> GetProductsListWithCategory();
    }
}

