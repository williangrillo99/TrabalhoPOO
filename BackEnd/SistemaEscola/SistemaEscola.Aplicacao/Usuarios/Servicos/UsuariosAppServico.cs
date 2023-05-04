﻿using AutoMapper;
using SistemaEscola.Aplicacao.Usuarios.Servicos.Interface;
using SistemaEscola.DataTransfer.Usuarios.Request;
using SistemaEscola.DataTransfer.Usuarios.Response;
using SistemaEscola.Dominio.Repositorio.Interface;
using SistemaEscola.Dominio.Usuarios.Entidade;
using SistemaEscola.Dominio.Usuarios.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Aplicacao.Usuarios.Servicos
{
    public class UsuariosAppServico : IUsuariosAppServico
    {
        private IMapper mapper { get; }
        private readonly IUsuarioServico usuarioServico;
        private readonly IRepositorioGenerico<Usuario> repositorioGenerico;

        public UsuariosAppServico(
            IUsuarioServico usuarioServico,
            IRepositorioGenerico<Usuario> repositorioGenerico,
            IMapper mapper) {

            this.repositorioGenerico = repositorioGenerico;
            this.usuarioServico = usuarioServico;
            this.mapper = mapper;
        }

        public async Task<UsuarioResponse> Adicionar(UsuarioRequest request)
        {
            var usuario = usuarioServico.InstanciarUsuarioAdmin(request.Nome);

            await repositorioGenerico.AdicionarAsync(usuario);

            await repositorioGenerico.SalvarAsync();

            return mapper.Map<UsuarioResponse>(usuario);
        }

        public async Task<List<UsuarioResponse>> ListaUsuarios()
        {
            var usuario = await repositorioGenerico.RecuperarAsync(null, null);

            return mapper.Map<List<UsuarioResponse>>(usuario);
        }
        public Usuario Logar(LoginRequest request)
        {

            var usuarioLogado = repositorioGenerico.Logar(request.Login, request.Senha);

            if (usuarioLogado == null)
            {
                throw new Exception("Aluno nao existe");
            }

            return usuarioLogado;
        }
        public async Task<Usuario> RecuperarPorId(int IdUsuario)
        {
            var usuario = await repositorioGenerico.RecuperarPorIdAsync(IdUsuario);

            mapper.Map<Usuario>(usuario);

            if (usuario == null)
            {
                throw new Exception("Usuairo nao existe");
            }
            return usuario;
        }

    }
}
