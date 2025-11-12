using System.Threading.Tasks;
using GymTrainerGuide.Web.Repositories;


namespace GymTrainerGuide.Web.Repositories
{
    public interface IRepository
    {
        // GET (obtener lista o recurso)
        Task<HttpResponseWrapper<T>> Get<T>(string url);

        // POST (crear)
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T data);

        // PUT (actualizar)
        Task<HttpResponseWrapper<object>> Put<T>(string url, T data);

        // DELETE (eliminar)
        Task<HttpResponseWrapper<object>> Delete(string url);
    }
}
