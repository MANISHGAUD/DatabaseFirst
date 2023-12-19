
using DataBaseFirstApporach.Models;

namespace DataBaseFirstApporach.Data
{
    public class BikeStore : IBikeStore
    {
        public BikeStore(BikeStoreContext bikeStoreContext)
        {
        }

        public Task<IEnumerable<Brand>> GetBrands()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderItem>> GetOrderItems()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetOrders()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Staff>> GetStaffs()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Stock>> GetStocks()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Store>> GetStores()
        {
            throw new NotImplementedException();
        }
    }
}
