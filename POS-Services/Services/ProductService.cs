using POS_Database.Core;
using POS_Database.DataModels;
using POS_Services.Interfaces;

namespace POS_Services.Services
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        public ProductService(POSContext serviceContext) : base(serviceContext)
        {
        }
    }
}
