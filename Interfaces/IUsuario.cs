using Senai.Projeto.Final.Final.web.Mvc.Models;

namespace Senai.Projeto.Final.Final.web.Mvc.Interfaces
{
    public interface IUsuario
    {
        UsuarioModel BuscarPorId(int id);
        UsuarioModel Cadastrar(UsuarioModel usuario);
        UsuarioModel Login(string email, string senha);
    }
}