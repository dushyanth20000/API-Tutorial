using ApiTutorial.DataAccesLayer;
using ApiTutorial.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApiTutorial.BusinessAccesLayer
{
    public class BusinessAcessLayer : IBusinessAcessLayer
    {
        private readonly ApiTutorialContext _apiTutorialContext;
        public BusinessAcessLayer(ApiTutorialContext apiTutorialContext)
        {
             _apiTutorialContext = apiTutorialContext;
        }
        public async Task<List<Customers>> Customers()
        {
          List<Customers> customers=await _apiTutorialContext.customers.ToListAsync();
            if (customers != null)
            {
                return customers;
            }
            return new List<Customers>();    
        }
    }
}
