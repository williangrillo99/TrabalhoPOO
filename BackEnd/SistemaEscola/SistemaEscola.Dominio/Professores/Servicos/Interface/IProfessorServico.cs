using SistemaEscola.Dominio.Professores.Entidade;
using SistemaEscola.Dominio.Usuarios.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Dominio.Professores.Servicos.Interface
{
    public interface IProfessorServico
    {
        Professor Instanciar(Usuario usuario, string nome);

    }
}
