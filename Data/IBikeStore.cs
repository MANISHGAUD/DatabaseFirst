using DataBaseFirstApporach.Models;

namespace DataBaseFirstApporach.Data
{
    public interface IBikeStore
    {
        Task<IEnumerable<Brand>> GetBrands();
        Task<IEnumerable<Category>> GetCategories();
        Task<IEnumerable<Product>> GetProducts();
        Task<IEnumerable<Customer>> GetCustomers();
        Task<IEnumerable<Order>> GetOrders();
        Task<IEnumerable<OrderItem>> GetOrderItems();
        Task<IEnumerable<Staff>> GetStaffs();
        Task<IEnumerable<Stock>> GetStocks();
        Task<IEnumerable<Store>> GetStores();
    }
}
