using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaEscola.Aplicacao.Professores.Servicos.Interface;
using SistemaEscola.Dominio.Professores.Entidade;

namespace SistemaEscola.API.Controllers.Professores
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessorController : ControllerBase
    {
        readonly private IProfessorAppServico professorAppServico;
        public ProfessorController(IProfessorAppServico professorAppServico) {
            this.professorAppServico = professorAppServico; 
        }
        
        [HttpPost]
        [Route("Adicionar")]
        public async Task<ActionResult<Professor>> Adicionar(string nome)
        {
            var resultado = await professorAppServico.Adicionar(nome);

            return Ok(resultado);
        }

    }
}
