using WebAPiS.DataContext;
using WebAPiS.Models;

namespace WebAPiS.Service.FuncionarioService
{
    public class FuncionarioService : IFuncionarioInterface
    {
        private readonly ApplicationDbContext _context;
        public FuncionarioService(ApplicationDbContext context) 
        {
            _context = context;

        }
        public async Task<ServiceResponce<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario)
        {
            ServiceResponce<List<FuncionarioModel>> serviceResponce = new ServiceResponce<List<FuncionarioModel>>();

            try 
            {
                if(novoFuncionario == null) 
                {
                    serviceResponce.Dados = null;
                    serviceResponce.Mensagem = "Informar dados!";
                    serviceResponce.Sucesso = false;

                    return serviceResponce;
                }

                _context.Add(novoFuncionario);
                await _context.SaveChangesAsync();

                serviceResponce.Dados = _context.Funcionarios.ToList();

            }catch (Exception ex)
            {
                serviceResponce.Mensagem = ex.Message;
                serviceResponce.Sucesso = false;
            }
            return serviceResponce;
        }

        public Task<ServiceResponce<List<FuncionarioModel>>> DeleteFuncionario(int id)
        {
            throw new NotImplementedException();
        }


        public Task<ServiceResponce<FuncionarioModel>> GetFuncionarioById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponce<List<FuncionarioModel>>> GetFuncionario()
        {
            ServiceResponce<List<FuncionarioModel>> serviceResponce = new ServiceResponce<List<FuncionarioModel>>();

            try
            {
                serviceResponce.Dados = _context.Funcionarios.ToList();
                if(serviceResponce.Dados.Count == 0)
                {
                    serviceResponce.Mensagem = "Nenhum dado encontrado!";
                }
            }
            catch (Exception ex)
            {
                serviceResponce.Mensagem = ex.Message;
                serviceResponce.Sucesso = false;

            }
            return serviceResponce; 

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
