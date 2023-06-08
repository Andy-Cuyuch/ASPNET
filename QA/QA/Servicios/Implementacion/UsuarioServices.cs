using Microsoft.EntityFrameworkCore;
using QA.Models;
using QA.Servicios.Contrato;

namespace QA.Servicios.Implementacion
{
    public class UsuarioServices : IUsuarioService
    {
        private readonly AspsolutionsContext _context;
        public UsuarioServices(AspsolutionsContext dbcontext)
        {
            _context = dbcontext;
        }

        public Task<Registerlog> GetRegisterlog(string correo, string clave)
        {
            throw new NotImplementedException();
        }

        //public async Task<Registerlog> GetRegisterlog(string correo, string clave)
        //{
        //    Registerlog registerView = await _context.Registerlogs.Where
        //        (u => u.Correo == correo && u.Clave == clave).FirstOrDefaultAsync();
        //}

        public async Task<Registerlog> SaveUser(Registerlog modelo)
        {
           _context.Registerlogs.Add(modelo);
            await _context.SaveChangesAsync();
            return modelo; 
        }

    }
}
