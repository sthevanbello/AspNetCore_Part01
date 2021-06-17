using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Parte_01
{
    public class Relatorio : IRelatorio
    {
        private readonly ICatalogo _catalogo;

        public Relatorio(ICatalogo catalogo)
        {
            _catalogo = catalogo;
        }

        public async Task Imprimir(HttpContext context)
        {
            foreach (var livro in _catalogo.GetLivros())
            {
                await context.Response.WriteAsync($"{livro.Codigo,-10}{livro.Nome,-40}{livro.Preco.ToString("C"),10}\n");

            }
        }
    }
}
