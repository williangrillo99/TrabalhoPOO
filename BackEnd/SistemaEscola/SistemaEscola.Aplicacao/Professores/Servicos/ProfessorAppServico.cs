using SistemaEscola.Aplicacao.Professores.Servicos.Interface;
using SistemaEscola.Dominio.Professores.Entidade;
using SistemaEscola.Dominio.Professores.Servicos.Interface;
using SistemaEscola.Dominio.Repositorio.Interface;
using SistemaEscola.Dominio.Usuarios.Entidade;
using SistemaEscola.Dominio.Usuarios.Enum;
using SistemaEscola.Dominio.Usuarios.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Aplicacao.Professores.Servicos
{
    public class ProfessorAppServico : IProfessorAppServico
    {
        private readonly IUsuarioServico usuarioServico;
        private readonly IProfessorServico professorServico;
        private readonly IRepositorioGenerico<Professor> repositorioGenerico;
        public ProfessorAppServico(IUsuarioServico usuarioServico, IProfessorServico professorServico, IRepositorioGenerico<Professor> repositorioGenerico) {
            this.usuarioServico = usuarioServico;
            this.professorServico = professorServico;
            this.repositorioGenerico = repositorioGenerico;
        }

        public async Task<Professor> Adicionar(string nome)
        {
            Usuario usuarioProfessor = usuarioServico.InstanciarUsuarioProfessor(nome); 

            Professor professor = professorServico.Instanciar(usuarioProfessor, nome);

            await repositorioGenerico.AdicionarAsync(professor);

            await repositorioGenerico.SalvarAsync();

            return professor;
        }
    }
}
