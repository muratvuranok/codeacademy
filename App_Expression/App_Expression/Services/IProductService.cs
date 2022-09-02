using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace App_Expression.Services;

//public interface IRepository
//{
//    ICollection<Product> GetProducts(Expression<Func<Product, bool>> predicate);
//}


//public class Repository<Product> : IRepository
//{
//    ICollection<Product> products = new List<Product>(); 
//    public ICollection<App_Expression.Product> GetProducts(Expression<Func<App_Expression.Product, bool>> predicate)
//    {
//        return products.Where(predicate).to;
//    }
//}






public interface IProductService
{
    /// <summary>
    /// Get All Products
    /// </summary>
    /// <returns></returns>
    ICollection<Product> GetProducts();

    ICollection<Product> GetProducts(Expression<Func<Product, bool>> predicate);
}
public class ProductService : IProductService
{

    DbSet<Product> _products = null;
    public ICollection<Product> GetProducts()
    {
        throw new NotImplementedException();
    }

    public ICollection<Product> GetProducts(Expression<Func<Product, bool>> predicate)
    {
        return _products.Where(predicate).ToList();
    }
}



public static class IEnumerableHelpers
{
    public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> source, bool condition, Func<T, bool> predicate)
    { 
        return condition ? source.Where(predicate) : source; 
    }
}