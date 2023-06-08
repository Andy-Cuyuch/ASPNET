using QA.Models;

namespace QA.Servicios.Contrato
{
    public interface IUsuarioService
    {
        Task<Registerlog> GetRegisterlog(string correo, string clave);
        Task<Registerlog> SaveUser(Registerlog modelo);

    }
}
