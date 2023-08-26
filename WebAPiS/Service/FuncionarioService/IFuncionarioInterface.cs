using WebAPiS.Models;

namespace WebAPiS.Service.FuncionarioService
{
    public interface IFuncionarioInterface
    {
        Task<ServiceResponce<List<FuncionarioModel>>> GetFuncionario();
        Task<ServiceResponce<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario);
        Task<ServiceResponce<FuncionarioModel>> GetFuncionarioById(int id);
        Task<ServiceResponce<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel editaFuncionario);
        Task<ServiceResponce<List<FuncionarioModel>>> DeleteFuncionario(int id);
        Task<ServiceResponce<List<FuncionarioModel>>> InativaFuncionario(int id);
    }
}
