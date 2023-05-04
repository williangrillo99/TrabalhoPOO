using SistemaEscola.Dominio.Professores.Entidade;
using SistemaEscola.Dominio.Professores.Servicos.Interface;
using SistemaEscola.Dominio.Usuarios.Entidade;
using SistemaEscola.Dominio.Usuarios.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Dominio.Professores.Servicos
{
    public class ProfessorServico : IProfessorServico
    {
        private readonly IUsuarioServico  usuarioServico;
        public ProfessorServico(IUsuarioServico usuarioServico)
        {
            this.usuarioServico = usuarioServico;
        }  
        public Professor Instanciar(Usuario usuario, string nome)
        {
            Usuario usuarioNovo = usuarioServico.InstanciarUsuarioProfessor(nome);

            Professor professor = new Professor(nome, usuarioNovo);

            return professor;
        }
    }
}
