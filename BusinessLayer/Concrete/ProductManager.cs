using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductSevrice
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product GetById(int id)
        {
            return _productDal.GetByID(id);
        }

        public void TInsert(Product t)
        {
            _productDal.Insert(t); 
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);  
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList();
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }

        public List<Product> GetProductsListWithCategory()
        {
            return _productDal.GetProductListWithCategory();
        }
    }
}
