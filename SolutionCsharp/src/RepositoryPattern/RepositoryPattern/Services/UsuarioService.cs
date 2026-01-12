using RepositoryPattern.Domain;
using RepositoryPattern.Repositories;

namespace RepositoryPattern.Services
{
    public class UsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public void CriarUsuario(string nome, string email)
        {
            var usuario = new Usuario(nome, email);
            _repository.Salvar(usuario);
        }
    }
}

/*
 
🚨 Aqui está o coração do Repository Pattern:

UsuarioService

❌ NÃO sabe se é SQL
❌ NÃO sabe se é Mongo
❌ NÃO sabe se é memória

Repository Pattern está em:
Interface: IUsuarioRepository
Implementação: UsuarioRepository
Service depende da interface

*/