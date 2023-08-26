using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPiS.Models;
using WebAPiS.Service.FuncionarioService;

namespace WebAPiS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioInterface _funcionarioInterface;
        public FuncionarioController(IFuncionarioInterface funcionarioInterface) 
        {
            _funcionarioInterface = funcionarioInterface;
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponce<List<FuncionarioModel>>>> GetFuncionarios()

        {
            return Ok( await _funcionarioInterface.GetFuncionario());
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponce<List<FuncionarioModel>>>> CreateFuncionario(FuncionarioModel novoFuncionario)
            
        {
           return Ok(await _funcionarioInterface.CreateFuncionario(novoFuncionario));
        }
    }
}
