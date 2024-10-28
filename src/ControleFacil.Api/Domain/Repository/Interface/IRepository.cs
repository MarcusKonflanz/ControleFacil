using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFacil.Api.Domain.Repository.Interface
{
    // T tipo
    // I interface 
    public interface IRepository<T, I> where T : class
    {
        Task<IEnumerable<T>> Obter();
        Task<T?> Obter(I id);
        Task<T> Adicionar(T entidade);
        Task<T> Atualizar(T entidade);
        Task<T> Deletar(T entidade);
    }
}