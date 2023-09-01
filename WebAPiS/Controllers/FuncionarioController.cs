using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using System.Collections.Generic;
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
            return Ok(await _funcionarioInterface.GetFuncionario());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponce<FuncionarioModel>>> GetFuncionarioById(int id)
        {
           ServiceResponce<FuncionarioModel> serviceResponce = await _funcionarioInterface.GetFuncionarioById(id);

            return Ok(serviceResponce);
        }


        [HttpPost]
        public async Task<ActionResult<ServiceResponce<List<FuncionarioModel>>>> CreateFuncionario(FuncionarioModel novoFuncionario)
            
        {
           return Ok(await _funcionarioInterface.CreateFuncionario(novoFuncionario));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponce<List<FuncionarioModel>>>> InativaFuncionario(int id)
        {
            ServiceResponce<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.InativaFuncionario(id);

            return Ok(serviceResponse);
        }
    }
}
