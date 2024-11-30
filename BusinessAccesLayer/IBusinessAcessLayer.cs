using ApiTutorial.Model.Domain;

namespace ApiTutorial.BusinessAccesLayer
{
    public interface IBusinessAcessLayer
    {
        Task<List<Customers>> Customers();
    }
}
