using DurbarSalesApp.Shared;

namespace DurbarSalesApp.Client.Services
{
    public interface IDurbarService
    {
        List<GenerateList> GenerateList { get; set; }
        Task GetList();

    }
}
