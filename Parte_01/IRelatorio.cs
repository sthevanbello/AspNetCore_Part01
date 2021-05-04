using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Parte_01
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}