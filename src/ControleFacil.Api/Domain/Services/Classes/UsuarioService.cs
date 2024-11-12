using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ControleFacil.Api.Contract.Usuario;
using ControleFacil.Api.Domain.Models;
using ControleFacil.Api.Domain.Repository.Interface;
using ControleFacil.Api.Domain.Services.Classes.Interfaces;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace ControleFacil.Api.Domain.Services.Classes
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }
        public async Task<UsuarioResponseContract> Adicionar(UsuarioRequestContract entidade, long idUsuario)
        {
            var usuario = _mapper.Map<Usuario>(entidade);
            usuario.Senha = GerarHashSenha(usuario.Senha);
            usuario = await _usuarioRepository.Adicionar(usuario);
            return _mapper.Map<UsuarioResponseContract>(usuario);
        }

        private string GerarHashSenha(string senha)
        {
            string hashSenha;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytsSenha = Encoding.UTF8.GetBytes(senha);
                byte[] bytesHashSenha = sha256.ComputeHash(bytsSenha);
                hashSenha = BitConverter.ToString(bytesHashSenha).ToLower();
            }
            return hashSenha;
        }

        public Task<UsuarioResponseContract> Atualizar(long id, UsuarioRequestContract entidade, long idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioLoginRequestContract> Autenticar(UsuarioLoginRequestContract usuarioLoginRequest)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioResponseContract> Inativar(long id, long idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UsuarioResponseContract>> Obter(long idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioResponseContract> Obter(long id, long idUsuario)
        {
            throw new NotImplementedException();
        }
    }
}