using SistemaEscola.Dominio.Alunos.Entidade;
using SistemaEscola.Dominio.Alunos.Servicos.Interface;
using SistemaEscola.Dominio.Usuarios.Entidade;
using SistemaEscola.Dominio.Usuarios.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Dominio.Alunos.Servicos
{
    public  class AlunoServico : IAlunoServico
    {
        private readonly IUsuarioServico usuarioServico;
        public AlunoServico(IUsuarioServico usuarioServico)
        {
            this.usuarioServico = usuarioServico;
        }

        public Aluno Instanciar(string nome)
        {
            Usuario usuario = usuarioServico.InstanciarUsuarioAluno(nome);
            Aluno aluno = new Aluno(usuario);

            return aluno;
        }
      
    }
}
