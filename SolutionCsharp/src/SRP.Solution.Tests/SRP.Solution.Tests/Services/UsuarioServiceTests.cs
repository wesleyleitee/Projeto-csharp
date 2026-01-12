using Moq;
using SRP.Solution.Interfaces;

namespace SRP.Solution.Tests.Services
{
    public class UsuarioServiceTests
    {
        [Fact]
        public void CriarUsuario_DadosValidos_DeveExecutarFluxoCompleto()
        {
            // Arrange
            var validatorMock = new Mock<IUsuarioValidator>();
            var repositoryMock = new Mock<IUsuarioRepository>();
            var emailServiceMock = new Mock<IEmailService>();

            var service = new UsuarioService(
                validatorMock.Object,
                repositoryMock.Object,
                emailServiceMock.Object
            );

            var nome = "Wesley";
            var email = "wesley@email.com";

            // Act
            service.CriarUsuario(nome, email);

            // Assert
            validatorMock.Verify(
                v => v.Validar(It.Is<Usuario>(u =>
                    u.Nome == nome &&
                    u.Email == email
                )),
                Times.Once
            );

            repositoryMock.Verify(
                r => r.Salvar(It.Is<Usuario>(u =>
                    u.Nome == nome &&
                    u.Email == email
                )),
                Times.Once
            );

            emailServiceMock.Verify(
                e => e.Enviar(email),
                Times.Once
            );
        }
    }
}
