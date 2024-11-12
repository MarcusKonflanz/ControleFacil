using ControleFacil.Api.Contract.Usuario;
using static ControleFacil.Api.Domain.Services.Classes.Interfaces.IService;

namespace ControleFacil.Api.Domain.Services.Classes.Interfaces
{
    public interface IUsuarioService : IService<UsuarioRequestContract, UsuarioResponseContract, long>
    {
        Task<UsuarioLoginRequestContract> Autenticar(UsuarioLoginRequestContract usuarioLoginRequest);
    }
}