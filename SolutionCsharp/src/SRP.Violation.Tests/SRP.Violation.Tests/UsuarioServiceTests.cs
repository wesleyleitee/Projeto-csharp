namespace SRP.Violation.Tests
{
    public class UsuarioServiceTests
    {
        [Fact]
        public void CriarUsuario_NomeInvalido_DeveLancarExcecao()
        {
            // Arrange
            var service = new UsuarioService();

            // Act & Assert
            var ex = Assert.Throws<Exception>(() =>
                service.CriarUsuario("", "teste@email.com"));

            Assert.Equal("Nome inválido", ex.Message);
        }

        [Fact]
        public void CriarUsuario_EmailInvalido_DeveLancarExcecao()
        {
            // Arrange
            var service = new UsuarioService();

            // Act & Assert
            var ex = Assert.Throws<Exception>(() =>
                service.CriarUsuario("Wesley", "emailinvalido"));

            Assert.Equal("Email inválido", ex.Message);
        }
    }
}
