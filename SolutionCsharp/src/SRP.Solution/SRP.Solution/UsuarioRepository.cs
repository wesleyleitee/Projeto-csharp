using SRP.Solution.Interfaces;

namespace SRP.Solution
{
    internal class UsuarioRepository: IUsuarioRepository
    {
        public void Salvar(Usuario usuario)
        {
            Console.WriteLine("Salvando usuário no banco de dados...");
        }
    }
}
