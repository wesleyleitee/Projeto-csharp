using System.Collections.Generic;
using OCP.Solution.Estrategias;

namespace OCP.Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var estrategias = new List<INotificacaoPorTipoUsuario>
            {
                new NotificacaoUsuarioBasico(),
                new NotificacaoUsuarioPremium(),
                new NotificacaoUsuarioConvidado()
            };

            var usuarioService = new UsuarioService(estrategias);

            usuarioService.CriarUsuario(
                new Usuario("Wesley", "wesley@email.com", TipoUsuarioEnum.Premium)
            );

            usuarioService.CriarUsuario(
                new Usuario("Ana", "ana@email.com", TipoUsuarioEnum.Basico)
            );

            usuarioService.CriarUsuario(
                new Usuario("Joao", "joao@email.com", TipoUsuarioEnum.Convidado)
            );

            Console.ReadKey();
        }
    }
}
