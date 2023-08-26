using WebAPiS.Models;

namespace WebAPiS.Service.FuncionarioService
{
    public class FuncionarioService : IFuncionarioInterface
    {
        public Task<ServiceResponce<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponce<List<FuncionarioModel>>> DeleteFuncionario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponce<List<FuncionarioModel>>> GetFuncionario()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponce<FuncionarioModel>> GetFuncionarioById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponce<List<FuncionarioModel>>> InativaFuncionario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponce<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel editaFuncionario)
        {
            throw new NotImplementedException();
        }
    }
}
