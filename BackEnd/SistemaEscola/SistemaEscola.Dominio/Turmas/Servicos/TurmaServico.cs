using SistemaEscola.Dominio.Turmas.Entidade;
using SistemaEscola.Dominio.Turmas.Servicos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Dominio.Turmas.Servicos
{
    public class TurmaServico : ITurmaServico
    {
        public Turma Instanciar(string nome)
        {
            Turma turma = new Turma(nome);

            return turma;
        }
    }
}
