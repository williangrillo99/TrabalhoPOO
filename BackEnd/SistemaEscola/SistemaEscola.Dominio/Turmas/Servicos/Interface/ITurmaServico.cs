﻿using SistemaEscola.Dominio.Turmas.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Dominio.Turmas.Servicos.Interface
{
    public interface ITurmaServico
    {
        Turma Instanciar(string nome);
    }
}
